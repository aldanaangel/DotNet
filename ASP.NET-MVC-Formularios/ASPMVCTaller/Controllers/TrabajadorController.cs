using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASPMVCTaller.Models;

namespace TalerASPMVC.Controllers
{
    public class TrabajadorController : Controller
    {
        public ViewResult ProcesarFormularioTrabajador()
        {
            DatosTrabajador registroTrabajador = new DatosTrabajador();
            CalculoSalario controladorOperaciones = new CalculoSalario();

            string nombre       = "";
            string apellido     = "";
            int numeroHoras     = 0;
            double valorHoras   = 0.0;
            int valorRiesgo     = 2;

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
                numeroHoras = Convert.ToInt32(Request.Form["txt_Horas"].ToString());
                valorHoras  = Double.Parse(Request.Form["txt_Valor"].ToString());

                valorRiesgo = Convert.ToInt32(Request.Form["txt_Riesgo"].ToString());
                //*****************************************************
                //*****************************************************
                //realizando las operaciones necesarias

                double salarioBruto = controladorOperaciones.CalcularSalarioBruto(numeroHoras, valorHoras);
                double salud = controladorOperaciones.CalcularSalud(salarioBruto);
                double pension = controladorOperaciones.CalcularPension(salarioBruto);
                double riesgos = controladorOperaciones.CalcularRiesgo(salarioBruto, valorRiesgo);
                double totalDescuentos = controladorOperaciones.CalcularTotalDescuentos(salud, pension,riesgos);
                double sueldoNeto = controladorOperaciones.CalcularSueldoNeto(salarioBruto, totalDescuentos);
                ViewData["salarioBruto"]    = salarioBruto;
                ViewData["salud"]           = salud;
                ViewData["pension"]         = pension;
                ViewData["riesgos"]         = riesgos;
                ViewData["totalDescuentos"] = totalDescuentos;
                ViewData["sueldoNeto"]      = sueldoNeto;
                
                //*****************************************************
                //*****************************************************
                System.Diagnostics.Debug.WriteLine("nombre:  " + nombre);
                System.Diagnostics.Debug.WriteLine("apellido: " + apellido);
                System.Diagnostics.Debug.WriteLine("numeroHoras:" + numeroHoras);
                System.Diagnostics.Debug.WriteLine("valorHoras:" + valorHoras);
                System.Diagnostics.Debug.WriteLine("valorRiesgo:" + valorRiesgo);
                //*****************************************************
                //*****************************************************
                //Encapsulamos
                registroTrabajador.Nombre = nombre;
                registroTrabajador.Apellido = apellido;
                registroTrabajador.NumeroHoras = numeroHoras;
                registroTrabajador.ValorHoras = valorHoras;
                registroTrabajador.ValorRiesgo = valorRiesgo;
                
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

            return View("MostrarFormularioTrabajador", registroTrabajador);
        }
        //************************************************************
        //************************************************************
        //************************************************************
        //Controlador para manipular el cargue de la vista del formulario de captura
        //de datos
        public ActionResult LlenarFormularioTrabajador()
        {

            
            return View();
        }
        
        public ActionResult MostrarFormularioTrabajador()
        {


            return View();
        }
        

        //************************************************************
        //************************************************************
        //************************************************************
    }//Fin de la clase del controlador
}
