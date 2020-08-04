using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAplicacionWindows2.negocio
{
    public class DatosUsuario
    {
        //Atributos
        private string nombre;
        private string estadoCivil;
        private string trabajo;
        private string[] hobbies;
        private double salario;

        public string Nombre { get => nombre; set => nombre = value; }
        public string EstadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public string Trabajo { get => trabajo; set => trabajo = value; }
        public string[] Hobbies { get => hobbies; set => hobbies = value; }
        public double Salario { get => salario; set => salario = value; }
    }
}
