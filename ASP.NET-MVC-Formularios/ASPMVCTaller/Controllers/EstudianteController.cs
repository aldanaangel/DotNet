using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCTaller.Models;


namespace ASPMVCTaller.Controllers
{
    public class EstudianteController : Controller
    {
         public ViewResult ProcesarFormularioEstudiante()
        {
            DatosEstudiante registroEstudiante = new DatosEstudiante();
            CalculoNotas controladorOperaciones = new CalculoNotas();

            string nombre       = "";
            string apellido     = "";
            int nota1 = 0;
            int nota2 = 0;
            int nota3 = 0;

            try
            {
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("Procesando el request: " + Request.Form.ToString());
                System.Diagnostics.Debug.WriteLine("************************************");
                System.Diagnostics.Debug.WriteLine("************************************");
                //*****************************************************
                //*****************************************************
                nombre      = Request.Form["txt_Nombre"].ToString();
                apellido    = Request.Form["txt_Apellido"].ToString();
                nota1 = Convert.ToInt32(Request.Form["txt_Nota1"].ToString());
                nota2 = Convert.ToInt32(Request.Form["txt_Nota2"].ToString());
                nota3 = Convert.ToInt32(Request.Form["txt_Nota3"].ToString());
                //*****************************************************
                //*****************************************************
                //realizando las operaciones necesarias

                double valorNota1 = controladorOperaciones.CalcularNota1(nota1);
                double valorNota2 = controladorOperaciones.CalcularNota2(nota2);
                double valorNota3 = controladorOperaciones.CalcularNota3(nota3);
                double valorNotaTotal =
                    controladorOperaciones.CalcularNotaTotal(valorNota1, valorNota2, valorNota3);


                ViewData["ValorNota1"]    = valorNota1;
                ViewData["ValorNota2"]    = valorNota2;
                ViewData["ValorNota3"]    = valorNota3;
                ViewData["ValorNotaTotal"] = valorNotaTotal;


                //Encapsulamos
                registroEstudiante.Nombre = nombre;
                registroEstudiante.Apellido = apellido;
                registroEstudiante.Nota1 = valorNota1;
                registroEstudiante.Nota2 = valorNota2;
                registroEstudiante.Nota3 = valorNota3;
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

            return View("MostrarNotasEstudiante", registroEstudiante);
        }

        public ActionResult LlenarNotasEstudiante()
        {


            return View();
        }

        public ActionResult MostrarNotasEstudiante()
        {


            return View();
        }
    }

    
}