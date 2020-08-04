using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCTaller.Models
{
    public class CalculoSalario
    {
        double porcentajeSalud = 14.5;
        

        public double CalcularSalarioBruto (int numeroHoras, double valorHoras)
        {
            double salarioBruto = 0.0;
            salarioBruto = numeroHoras * valorHoras;
            return (salarioBruto);
        }

        public double CalcularSalud(double salarioBruto)
        {
            double porcentajeSalud = 14.5;
            double valorSalud = (salarioBruto * porcentajeSalud)/100;
            return (valorSalud);
        }

        public double CalcularPension(double salarioBruto)
        {
            double porcentajePension = 12.6;
            double valorPension = (salarioBruto * porcentajePension)/100;
            return (valorPension);
        }

        public double CalcularRiesgo(double salarioBruto, int tipoRiesgo)
        {
            double valorRiesgo = 0.0;

            switch (tipoRiesgo)
            {
                case 1:
                    valorRiesgo = (salarioBruto * 5) / 100;
                    break;
                case 2:
                    valorRiesgo = (salarioBruto * 14) / 100;
                    break;
                case 3:
                    valorRiesgo = (salarioBruto * 16) / 100;
                    break;
                case 4:
                    valorRiesgo = (salarioBruto * 33) / 100;
                    break;
                    
            }
            return (valorRiesgo);

        }
        public double CalcularTotalDescuentos(double salud, double pension, double riesgos)
        {
            double totalDescuentos = salud + pension + riesgos;
            return (totalDescuentos);
        }

        public double CalcularSueldoNeto(double sueldoBruto, double totalDescuentos)
        {
            double sueldoNeto = sueldoBruto - totalDescuentos;
            return (sueldoNeto);
        }

    }
}