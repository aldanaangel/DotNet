using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DemoAplicacionWindows2.negocio;

namespace DemoAplicacionWindows2
{
    public partial class FormularioControles : Form
    {

        private static LogicaNegocioFormulario controladorNegocio;

        //Constructor, creo la referencia al objeto de negocio
        public FormularioControles()
        {
            //Crear la instancia del objeto de negocio

            //Llamar la interface

            //Llamar la dependencia del otro objeto...
            controladorNegocio = new LogicaNegocioFormulario();
            InitializeComponent();
        }

        //Controlar la lógica de manipulación de la presentación
        //Controladores o Code Behind o Código subyacente

        //Managed beans
        //Clases de controlador Laravel o Yi --> PHP
        //Servlets de JEE

        //1.  Procesar los eventos
        //2.  Capturar los datos de la vista (Forms.cs --> Designer)
        //3.  Invocar la lógica de los demás objetos de la solución


        private void lblNombre_MouseEnter(object sender, EventArgs e)
        {
            MessageBox.Show("Nombre de la persona");
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre = "";
            string estado = "";
            string trabajo = "";
            string[] pasatiempos = null;


            //**********************************************
            //**********************************************
            //**********************************************
            //Procesamos los datos del formulario y los recuperamos
            nombre = this.txtNombre.Text;

            estado = obtenerValorEstadoCivil();
            System.Diagnostics.Debug.WriteLine("Estado civil del usuario: " + estado);

            trabajo = obtenerTrabajo();
            System.Diagnostics.Debug.WriteLine("Trabajo del usuario: " + trabajo);
            pasatiempos = obtenerHobbies();
            //**********************************************
            //**********************************************
            //**********************************************
            //Enlazar con la lógica de negocio
            DatosUsuario registro = null;
            //Llamar la fachada del objeto de negocio, pasándole como parámetros
            //los datos capturados en la lógica de presentación
            registro = controladorNegocio.obtenerDatosFormularioProcesados(nombre, estado, trabajo, pasatiempos);


            //Actualizar la vista formulario (System.Console.Write....)
            this.lblNombre2.Text = registro.Nombre;
            this.lblEstadoCivil2.Text = registro.EstadoCivil;
            this.lblTrabajo2.Text = registro.Trabajo;

            string aficiones = "";
            for (int a = 0; a < registro.Hobbies.Count(); a++)
            {
                aficiones += registro.Hobbies[a].ToString() + " - ";
            }

            this.txtAficiones.Text = aficiones.Substring(0,aficiones.LastIndexOf("-")-1);

            this.lblSalarioFinal.Text = registro.Salario.ToString();
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = "";
            this.rbOpcionCasado.Checked = false;
            this.rbOpcionSoltero.Checked = false;
            this.comboTrabajo.SelectedIndex = 0;

            //Remueve los ítems de la lista
            /*
            for (int x = (this.listaCBAficiones.SelectedIndex - 1); x >= 0; x--)
            {
                this.listaCBAficiones.Items.RemoveAt(x);
            }
            */

            // Clear all selections in the ListBox.
            this.listaCBAficiones.ClearSelected();
        }

        /*
        public xxxx....()
        {

        }
        */

        /*
                Crear instancia de objetos del modelo
                Pasar la referencia a través de interfaces
                Crear objetos de referencia de otros elementos
         */

        /*
            Procesar directamente la lógica -->  Métodos del negocio
            MALA PRÁCTICA
            NOS MEZCLA EN UN SOLO MONOLITO LA LÓGICA DE NEGOCIO
            CON LA LÓGICA DE PRESENTACIÓN
         */
        private string obtenerValorEstadoCivil()
        {
            string estado = "";

            if (this.rbOpcionCasado.Checked)
            {
                estado = this.rbOpcionCasado.Text;
            }

            if (this.rbOpcionSoltero.Checked)
            {
                estado = this.rbOpcionSoltero.Text;
            }

            return (estado);
        }

        public string obtenerTrabajo()
        {
            string trabajo = "";
            int indice = this.comboTrabajo.SelectedIndex;
            object valor = this.comboTrabajo.SelectedItem;
            trabajo = valor.ToString();

            //Formatear el valor a recuperar del combo

            return (trabajo);
        }

        public string[] obtenerHobbies()
        {
            string[] hobbies = null;
            string itemEscogido = "";
            int tamano = 0;
            tamano = this.listaCBAficiones.CheckedItems.Count;

            //Instancia del arreglo
            hobbies = new string[tamano];

            for (int x = 0; x < tamano; x++)
            {
                hobbies[x] = this.listaCBAficiones.CheckedItems[x].ToString();
                System.Diagnostics.Debug.WriteLine("item escogido: " + hobbies[x]);
            }

            return (hobbies);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aplicación de manejo de controles hecha " + System.DateTime.Now.ToLongDateString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Saliendo de la app WinForm");
            Application.Exit();
        }
    }
}
