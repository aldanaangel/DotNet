namespace DemoAplicacionWindows2
{
    partial class FormularioControles
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.grupoUsuario = new System.Windows.Forms.GroupBox();
            this.lblAficiones = new System.Windows.Forms.Label();
            this.listaCBAficiones = new System.Windows.Forms.CheckedListBox();
            this.lblTrabajo = new System.Windows.Forms.Label();
            this.comboTrabajo = new System.Windows.Forms.ComboBox();
            this.rbOpcionCasado = new System.Windows.Forms.RadioButton();
            this.rbOpcionSoltero = new System.Windows.Forms.RadioButton();
            this.lblEstadoCivil = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.grupoResultado = new System.Windows.Forms.GroupBox();
            this.lblSalarioFinal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAficiones = new System.Windows.Forms.TextBox();
            this.lblTrabajo2 = new System.Windows.Forms.Label();
            this.lblNombre2 = new System.Windows.Forms.Label();
            this.lblEstadoCivil2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAcercaDe = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.grupoUsuario.SuspendLayout();
            this.grupoResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoUsuario
            // 
            this.grupoUsuario.Controls.Add(this.lblAficiones);
            this.grupoUsuario.Controls.Add(this.listaCBAficiones);
            this.grupoUsuario.Controls.Add(this.lblTrabajo);
            this.grupoUsuario.Controls.Add(this.comboTrabajo);
            this.grupoUsuario.Controls.Add(this.rbOpcionCasado);
            this.grupoUsuario.Controls.Add(this.rbOpcionSoltero);
            this.grupoUsuario.Controls.Add(this.lblEstadoCivil);
            this.grupoUsuario.Controls.Add(this.txtNombre);
            this.grupoUsuario.Controls.Add(this.lblNombre);
            this.grupoUsuario.Location = new System.Drawing.Point(21, 23);
            this.grupoUsuario.Name = "grupoUsuario";
            this.grupoUsuario.Size = new System.Drawing.Size(355, 306);
            this.grupoUsuario.TabIndex = 0;
            this.grupoUsuario.TabStop = false;
            this.grupoUsuario.Text = "Usuario:";
            // 
            // lblAficiones
            // 
            this.lblAficiones.AutoSize = true;
            this.lblAficiones.Location = new System.Drawing.Point(25, 187);
            this.lblAficiones.Name = "lblAficiones";
            this.lblAficiones.Size = new System.Drawing.Size(53, 13);
            this.lblAficiones.TabIndex = 8;
            this.lblAficiones.Text = "Aficiones:";
            // 
            // listaCBAficiones
            // 
            this.listaCBAficiones.FormattingEnabled = true;
            this.listaCBAficiones.Items.AddRange(new object[] {
            "Pintura",
            "Música",
            "Gastronomía",
            "Videojuegos"});
            this.listaCBAficiones.Location = new System.Drawing.Point(114, 187);
            this.listaCBAficiones.Name = "listaCBAficiones";
            this.listaCBAficiones.Size = new System.Drawing.Size(120, 79);
            this.listaCBAficiones.TabIndex = 7;
            // 
            // lblTrabajo
            // 
            this.lblTrabajo.AutoSize = true;
            this.lblTrabajo.Location = new System.Drawing.Point(25, 129);
            this.lblTrabajo.Name = "lblTrabajo";
            this.lblTrabajo.Size = new System.Drawing.Size(46, 13);
            this.lblTrabajo.TabIndex = 6;
            this.lblTrabajo.Text = "Trabajo:";
            // 
            // comboTrabajo
            // 
            this.comboTrabajo.FormattingEnabled = true;
            this.comboTrabajo.Items.AddRange(new object[] {
            "Seleccione una opción",
            "Médico",
            "Ingeniero",
            "Panadero",
            "Abogado"});
            this.comboTrabajo.Location = new System.Drawing.Point(114, 129);
            this.comboTrabajo.Name = "comboTrabajo";
            this.comboTrabajo.Size = new System.Drawing.Size(168, 21);
            this.comboTrabajo.TabIndex = 5;
            this.comboTrabajo.SelectedIndex = 0;
            // 
            // rbOpcionCasado
            // 
            this.rbOpcionCasado.AutoSize = true;
            this.rbOpcionCasado.Location = new System.Drawing.Point(189, 81);
            this.rbOpcionCasado.Name = "rbOpcionCasado";
            this.rbOpcionCasado.Size = new System.Drawing.Size(61, 17);
            this.rbOpcionCasado.TabIndex = 4;
            this.rbOpcionCasado.TabStop = true;
            this.rbOpcionCasado.Text = "Casado";
            this.rbOpcionCasado.UseVisualStyleBackColor = true;
            // 
            // rbOpcionSoltero
            // 
            this.rbOpcionSoltero.AutoSize = true;
            this.rbOpcionSoltero.Location = new System.Drawing.Point(114, 81);
            this.rbOpcionSoltero.Name = "rbOpcionSoltero";
            this.rbOpcionSoltero.Size = new System.Drawing.Size(58, 17);
            this.rbOpcionSoltero.TabIndex = 3;
            this.rbOpcionSoltero.TabStop = true;
            this.rbOpcionSoltero.Text = "Soltero";
            this.rbOpcionSoltero.UseVisualStyleBackColor = true;
            // 
            // lblEstadoCivil
            // 
            this.lblEstadoCivil.AutoSize = true;
            this.lblEstadoCivil.Location = new System.Drawing.Point(25, 81);
            this.lblEstadoCivil.Name = "lblEstadoCivil";
            this.lblEstadoCivil.Size = new System.Drawing.Size(65, 13);
            this.lblEstadoCivil.TabIndex = 2;
            this.lblEstadoCivil.Text = "Estado Civil:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(114, 36);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(25, 39);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.MouseEnter += new System.EventHandler(this.lblNombre_MouseEnter);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(33, 359);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(137, 23);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Procesar datos";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.Location = new System.Drawing.Point(220, 359);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(136, 23);
            this.btnReestablecer.TabIndex = 2;
            this.btnReestablecer.Text = "Reestablecer";
            this.btnReestablecer.UseVisualStyleBackColor = true;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // grupoResultado
            // 
            this.grupoResultado.Controls.Add(this.lblSalarioFinal);
            this.grupoResultado.Controls.Add(this.label6);
            this.grupoResultado.Controls.Add(this.txtAficiones);
            this.grupoResultado.Controls.Add(this.lblTrabajo2);
            this.grupoResultado.Controls.Add(this.lblNombre2);
            this.grupoResultado.Controls.Add(this.lblEstadoCivil2);
            this.grupoResultado.Controls.Add(this.label4);
            this.grupoResultado.Controls.Add(this.label3);
            this.grupoResultado.Controls.Add(this.label2);
            this.grupoResultado.Controls.Add(this.label1);
            this.grupoResultado.Location = new System.Drawing.Point(410, 23);
            this.grupoResultado.Name = "grupoResultado";
            this.grupoResultado.Size = new System.Drawing.Size(278, 306);
            this.grupoResultado.TabIndex = 3;
            this.grupoResultado.TabStop = false;
            this.grupoResultado.Text = "Datos capturados";
            // 
            // lblSalarioFinal
            // 
            this.lblSalarioFinal.AutoSize = true;
            this.lblSalarioFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFinal.Location = new System.Drawing.Point(117, 269);
            this.lblSalarioFinal.Name = "lblSalarioFinal";
            this.lblSalarioFinal.Size = new System.Drawing.Size(0, 20);
            this.lblSalarioFinal.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Salario";
            // 
            // txtAficiones
            // 
            this.txtAficiones.Location = new System.Drawing.Point(117, 179);
            this.txtAficiones.Multiline = true;
            this.txtAficiones.Name = "txtAficiones";
            this.txtAficiones.ReadOnly = true;
            this.txtAficiones.Size = new System.Drawing.Size(100, 74);
            this.txtAficiones.TabIndex = 13;
            // 
            // lblTrabajo2
            // 
            this.lblTrabajo2.AutoSize = true;
            this.lblTrabajo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrabajo2.Location = new System.Drawing.Point(113, 132);
            this.lblTrabajo2.Name = "lblTrabajo2";
            this.lblTrabajo2.Size = new System.Drawing.Size(0, 20);
            this.lblTrabajo2.TabIndex = 12;
            // 
            // lblNombre2
            // 
            this.lblNombre2.AutoSize = true;
            this.lblNombre2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre2.Location = new System.Drawing.Point(113, 36);
            this.lblNombre2.Name = "lblNombre2";
            this.lblNombre2.Size = new System.Drawing.Size(0, 20);
            this.lblNombre2.TabIndex = 11;
            // 
            // lblEstadoCivil2
            // 
            this.lblEstadoCivil2.AutoSize = true;
            this.lblEstadoCivil2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstadoCivil2.Location = new System.Drawing.Point(117, 78);
            this.lblEstadoCivil2.Name = "lblEstadoCivil2";
            this.lblEstadoCivil2.Size = new System.Drawing.Size(0, 20);
            this.lblEstadoCivil2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Aficiones:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Trabajo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Estado Civil:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // btnAcercaDe
            // 
            this.btnAcercaDe.Location = new System.Drawing.Point(410, 359);
            this.btnAcercaDe.Name = "btnAcercaDe";
            this.btnAcercaDe.Size = new System.Drawing.Size(75, 23);
            this.btnAcercaDe.TabIndex = 4;
            this.btnAcercaDe.Text = "Acerca De";
            this.btnAcercaDe.UseVisualStyleBackColor = true;
            this.btnAcercaDe.Click += new System.EventHandler(this.btnAcercaDe_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(564, 359);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(124, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // FormularioControles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 405);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAcercaDe);
            this.Controls.Add(this.grupoResultado);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.grupoUsuario);
            this.Name = "FormularioControles";
            this.Text = "Mi formulario con más controles de Windows FORMS";
            this.grupoUsuario.ResumeLayout(false);
            this.grupoUsuario.PerformLayout();
            this.grupoResultado.ResumeLayout(false);
            this.grupoResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoUsuario;
        private System.Windows.Forms.RadioButton rbOpcionCasado;
        private System.Windows.Forms.RadioButton rbOpcionSoltero;
        private System.Windows.Forms.Label lblEstadoCivil;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTrabajo;
        private System.Windows.Forms.ComboBox comboTrabajo;
        private System.Windows.Forms.Label lblAficiones;
        private System.Windows.Forms.CheckedListBox listaCBAficiones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.GroupBox grupoResultado;
        private System.Windows.Forms.TextBox txtAficiones;
        private System.Windows.Forms.Label lblTrabajo2;
        private System.Windows.Forms.Label lblNombre2;
        private System.Windows.Forms.Label lblEstadoCivil2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSalarioFinal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAcercaDe;
        private System.Windows.Forms.Button btnSalir;
    }
}

