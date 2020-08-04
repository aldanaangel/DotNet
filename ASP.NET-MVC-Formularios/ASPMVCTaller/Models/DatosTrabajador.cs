using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace ASPMVCTaller.Models
{
    public class DatosTrabajador
    {
       // [Display(Name = "registroTrabajador")]

        private string nombre;
        private string apellido;
        private int numeroHoras;
        private double valorHoras;
        private int valorRiesgo;

        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int NumeroHoras { get => numeroHoras; set => numeroHoras = value; }
        public double ValorHoras { get => valorHoras; set => valorHoras = value; }
        public int ValorRiesgo { get => valorRiesgo; set => valorRiesgo = value; }
    }
}