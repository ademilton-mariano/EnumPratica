using Curso.Entidades.Enums;
using System.Collections.Generic;

namespace Curso.Entidades {
    class Trabalhador {
        public string Nome { get; set; }
        public NivelTrabalhador Nivel { get; set; }
        public double SalarioBase { get; set; }
        public Departamento Departamento { get; set; }
        public List<HoraContrato> Contratos { get; private set; } = new List<HoraContrato>();

        public Trabalhador(string nome, NivelTrabalhador nivel, double salarioBase, Departamento departamento) {
            Nome = nome;
            Nivel = nivel;
            SalarioBase = salarioBase;
            Departamento = departamento;
        }

        public Trabalhador() {
        }

        public void AddContrato(HoraContrato contrato) {
            Contratos.Add(contrato);
        }

        public void RemoveContrato(HoraContrato contrato) {
            Contratos.Remove(contrato);
        }

        public double Renda(int ano, int mes) {
            double soma = SalarioBase;
            foreach (HoraContrato contrato in Contratos) {
                if (contrato.Data.Year == ano && contrato.Data.Month == mes) {
                    soma += contrato.ValorTotal();
                }
            }
            return soma;
        }
    }
}
