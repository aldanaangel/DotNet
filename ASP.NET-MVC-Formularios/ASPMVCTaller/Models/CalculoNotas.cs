using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCTaller.Models
{
    public class CalculoNotas
    {
        public double CalcularNota1(int nota)
        {
            double valorNota = 30;

            double nota1 = (nota * valorNota) / 100;
            return (nota1);

        }
        public double CalcularNota2(int nota)
        {
            double valorNota = 30;

            double nota2 = (nota * valorNota) / 100;
            return (nota2);

        }
        public double CalcularNota3(int nota)
        {
            double valorNota = 40;

            double nota3 = (nota * valorNota) / 100;
            return (nota3);
        }

        public double CalcularNotaTotal(double nota1, double nota2, double nota3)
        {
            double valorNotaTotal = 0;

            valorNotaTotal = (nota1 + nota2 + nota3);
            return (valorNotaTotal);
        }





    }
}