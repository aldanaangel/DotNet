using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASPMVCTaller.Models
{
    public class DatosEstudiante
    {
        private string nombre;
        private string apellido;
        private double nota1;
        private double nota2;
        private double nota3;
        private double notaTotal;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double NotaTotal { get => notaTotal; set => notaTotal = value; }
    }
}