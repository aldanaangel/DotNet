using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolucionEnsayoMVC.Models
{
    /// <summary>
    /// Clase correspondiente al model con los atributos del estudiante
    /// </summary>
    public class DatosEstudiante
    {
        private string nombre;
        private string apellido;
        private double nota1;
        private double nota2;
        private double nota3;
        private double nota4;
        private double notaTotal;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public double Nota1 { get => nota1; set => nota1 = value; }
        public double Nota2 { get => nota2; set => nota2 = value; }
        public double Nota3 { get => nota3; set => nota3 = value; }
        public double Nota4 { get => nota4; set => nota4 = value; }
        public double NotaTotal { get => notaTotal; set => notaTotal = value; }
    }
}