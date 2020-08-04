using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAplicacionWindows2.negocio
{
    public class LogicaNegocioFormulario
    {
        //Métodos
        private DatosUsuario datosUsuarioFormulario;
        //Negocio sin la interfaz gráfica los elementos


        //CERO LÓGICA DE PRESENTACIÓN
        //SOLO NEGOCIO

        public DatosUsuario obtenerDatosFormularioProcesados
        (string nombre, string estadoCivil, string trabajo, string [] hobbies)
        {
            System.Diagnostics.Debug.WriteLine("Entrando al método de negocio");
            //Lógica en esta clase para procesar esos datos sin nada
            //que ver con la presentación manejada en el code behind del
            //Windows Form
            DatosUsuario registro = new DatosUsuario();
            double salario = 0.0;

            registro.Nombre = nombre;
            registro.EstadoCivil = estadoCivil;
            registro.Trabajo = trabajo;
            registro.Hobbies = hobbies;

            if (estadoCivil.Equals("Soltero"))
            {
                salario = 1500000;
            }
            else
            {
                salario = 4000000;
            }

            System.Diagnostics.Debug.WriteLine("Salario asignado por el tipo de estado civil: " + salario);
            registro.Salario = salario;

            //Acceso a datos
            //Lógica adicional
            //Interacción con otros objetos
            //Acceso a datos
            //Consultas
            //Otros recursos de la aplicación u otras aplicaciones
            //Recursos del SO o el ambiente de ejecución del CLR
            return (registro);
        }
    }
}
