using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SolucionEnsayoMVC.Models;

namespace SolucionEnsayoMVC.Controllers
{
    public class EstudianteController : Controller
    {
        /// <summary>
        /// ViewResult para pocesar los datos ingresados en el formulario
        /// del estudiante, este será implementado en el action del submit del fomulario
        /// en la vista CapturarDatosEstudiante
        /// </summary>
        /// <returns>
        /// Encapsulamiento de los datos capturados siguiendo el model DatosEstudiante
        /// </returns>
        public ViewResult ProcesarFormularioEstudiante()
        {
            DatosEstudiante registroEstudiante = new DatosEstudiante();
            OperacionesEstudiante controladorOperaciones = new OperacionesEstudiante();

            string nombreEstudiante = "";
            string apellidoEstudiante = "";
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;
            int nota4 = 0;

            try
            {
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("Procesando el request: " + Request.Form.ToString());
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                //*****************************************************
                //*****************************************************
                nombreEstudiante = Request.Form["txt_Nombre"].ToString();
                apellidoEstudiante = Request.Form["txt_Apellido"].ToString();
                nota1 = Convert.ToInt32(Request.Form["txt_Nota1"].ToString());
                nota2 = Convert.ToInt32(Request.Form["txt_Nota2"].ToString());
                nota3 = Convert.ToInt32(Request.Form["txt_Nota3"].ToString());
                nota4 = Convert.ToInt32(Request.Form["txt_Nota4"].ToString());
                //*****************************************************
                //*****************************************************
                //realizando las operaciones necesarias

                double valorNota1 = controladorOperaciones.CalcularNotaPrimerCorte(nota1);
                double valorNota2 = controladorOperaciones.CalcularNotaSegundoCorte(nota2);
                double valorNota3 = controladorOperaciones.CalcularNotaTercerCorte(nota3);
                double valorNota4 = controladorOperaciones.CalcularNotaCuartoCorte(nota4);
                double valorNotaTotal =
                    controladorOperaciones.CalcularNotaTotal(valorNota1, valorNota2, valorNota3, valorNota4);


                ViewData["ValorNota1"] = nota1;
                ViewData["ValorNota2"] = nota2;
                ViewData["ValorNota3"] = nota3;
                ViewData["ValorNota4"] = nota4;
                


                //Encapsulamos
                registroEstudiante.Nombre = nombreEstudiante;
                registroEstudiante.Apellido = apellidoEstudiante;
                registroEstudiante.Nota1 = valorNota1;
                registroEstudiante.Nota2 = valorNota2;
                registroEstudiante.Nota3 = valorNota3;
                registroEstudiante.Nota4 = valorNota4;
                registroEstudiante.NotaTotal = valorNotaTotal;

                //*****************************************************
                //*****************************************************
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
            }

            catch (Exception errorProcesamientoControlador)
            {
                System.Diagnostics.Debug.WriteLine("Error en el controlador: " + errorProcesamientoControlador.Message);
                System.Diagnostics.Debug.WriteLine("Error detallado: " + errorProcesamientoControlador.ToString());
            }

            return View("MostrarDatosEstudiante", registroEstudiante);
        }
        public ActionResult CapturarDatosEstudiante()
        {


            return View();
        }
        public ActionResult MostrarDatosEstudiante()
        {


            return View();
        }

    }
}