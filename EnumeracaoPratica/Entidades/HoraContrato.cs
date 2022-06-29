using System;

namespace Curso.Entidades {
    class HoraContrato {

        public DateTime Data { get; set; }
        public double ValorHora { get; set; }
        public int Horas { get; set; }

        public HoraContrato() {
        }

        public HoraContrato(DateTime data, double valorHora, int horas) {
            Data = data;
            ValorHora = valorHora;
            Horas = horas;
        }

        public double ValorTotal() {
            return Horas * ValorHora;
        }
    }
}
