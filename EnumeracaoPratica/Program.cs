using System;
using System.Globalization;
using Curso.Entidades;
using Curso.Entidades.Enums;

namespace Curso {
    class Program {
        static void Main(string[] args) {

            Console.Write("Digite o nome do departamento: ");
            string dNome = Console.ReadLine();
            Console.WriteLine("digite os dados do trabalhador:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Nivel: (Junior/Pleno/Senior): ");
            NivelTrabalhador nivel = Enum.Parse<NivelTrabalhador>(Console.ReadLine());
            Console.Write("Salário base: ");
            double salarioBase = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Departamento dept = new Departamento(dNome);
            Trabalhador trab = new Trabalhador(nome, nivel, salarioBase, dept);

            Console.Write("Quantos contratos tem esse trabalhador? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) {
                Console.WriteLine("Digite a data do contrato #" + i);
                Console.Write("Data (DD/MM/YYYY): ");
                DateTime data = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade de horas: ");
                int horas = int.Parse(Console.ReadLine());
                HoraContrato contrato = new HoraContrato(data, valorHora, horas);
                trab.AddContrato(contrato);
            }

            Console.WriteLine();
            Console.Write("Digite o mês e ano da renda que deseja consultar: (MM/YYYY) ");
            string pRenda = Console.ReadLine();
            int mes = int.Parse(pRenda.Substring(0, 2));
            int ano = int.Parse(pRenda.Substring(3));
            Console.WriteLine("Nome : " + trab.Nome);
            Console.WriteLine("Departamento: " + trab.Departamento.Nome);
            Console.WriteLine("Renda Mensal " + pRenda + ": " + trab.Renda(ano, mes).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

