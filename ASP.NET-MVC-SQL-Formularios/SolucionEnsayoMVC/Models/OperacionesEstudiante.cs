using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SolucionEnsayoMVC.Models
{
    /// <summary>
    /// Clase diseñada para contener todas las operaciones referentes
    /// al estudiante luego de capturar los datos en el formulario correspondiente
    /// </summary>
    public class OperacionesEstudiante
    {
        /// <summary>
        /// Método para calcular la nota equivalente del primer corte
        /// </summary>
        /// <param name="nota"> Hace regerencia al dato nota1 que se captura en el formulario
        /// y es pasado por parametro a la funcion </param>
        /// <returns> El resultado de la operacion luego de aplicarle el 
        /// porcentaje establecido a la nota capturada </returns>
        public double CalcularNotaPrimerCorte(int nota)
        {
            double porcentajeNota = 20;
            double nota1 = (nota * porcentajeNota) / 100;
            return (nota1);
        }

        public double CalcularNotaSegundoCorte(int nota)
        {
            double porcentajeNota = 20;
            double nota2 = (nota * porcentajeNota) / 100;
            return (nota2);

        }

        public double CalcularNotaTercerCorte(int nota)
        {
            double porcentajeNota = 30;
            double nota3 = (nota * porcentajeNota) / 100;
            return (nota3);
        }

        public double CalcularNotaCuartoCorte(int nota)
        {
            double porcentajeNota = 30;
            double nota3 = (nota * porcentajeNota) / 100;
            return (nota3);
        }

        /// <summary>
        /// Método para calcular la sumatoria total de las notas 
        /// correspondientes a cada corte.
        /// </summary>
        /// <param name="nota1">Parametro corespondiente a la nota del primer corte</param>
        /// <param name="nota2">Parametro corespondiente a la nota del segundo corte</param>
        /// <param name="nota3">Parametro corespondiente a la nota del tercer corte</param>
        /// <param name="nota4">Parametro corespondiente a la nota del cuarto corte</param>
        /// <returns>Suma total de las notas</returns>

        public double CalcularNotaTotal(double nota1, double nota2, double nota3, double nota4)
        {
            double valorNotaTotal = 0;
            valorNotaTotal = (nota1 + nota2 + nota3 + nota4);
            return (valorNotaTotal);
        }
    }
}