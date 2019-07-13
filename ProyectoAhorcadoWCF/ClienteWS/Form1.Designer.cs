namespace ClienteWS
{
    partial class Form1
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
            this.cmbDificultad = new System.Windows.Forms.ComboBox();
            this.btnIngresarLetra = new System.Windows.Forms.Button();
            this.txtLetrasIngresar = new System.Windows.Forms.TextBox();
            this.lblEscojaDificultad = new System.Windows.Forms.Label();
            this.lblPalabraFormandose = new System.Windows.Forms.Label();
            this.btnSeleccionarDificultad = new System.Windows.Forms.Button();
            this.lblExplicacion = new System.Windows.Forms.Label();
            this.lblExplicacionIntentos = new System.Windows.Forms.Label();
            this.lblConteoIntentos = new System.Windows.Forms.Label();
            this.lblAhorcado = new System.Windows.Forms.Label();
            this.lblResultadoJuego = new System.Windows.Forms.Label();
            this.btnEmpezarDeNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbDificultad
            // 
            this.cmbDificultad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDificultad.FormattingEnabled = true;
            this.cmbDificultad.Location = new System.Drawing.Point(143, 93);
            this.cmbDificultad.Name = "cmbDificultad";
            this.cmbDificultad.Size = new System.Drawing.Size(121, 21);
            this.cmbDificultad.TabIndex = 3;
            // 
            // btnIngresarLetra
            // 
            this.btnIngresarLetra.Location = new System.Drawing.Point(246, 194);
            this.btnIngresarLetra.Name = "btnIngresarLetra";
            this.btnIngresarLetra.Size = new System.Drawing.Size(92, 23);
            this.btnIngresarLetra.TabIndex = 4;
            this.btnIngresarLetra.Text = "Ingresar Letra";
            this.btnIngresarLetra.UseVisualStyleBackColor = true;
            this.btnIngresarLetra.Click += new System.EventHandler(this.btnIngresarLetra_Click);
            // 
            // txtLetrasIngresar
            // 
            this.txtLetrasIngresar.Location = new System.Drawing.Point(106, 194);
            this.txtLetrasIngresar.Name = "txtLetrasIngresar";
            this.txtLetrasIngresar.Size = new System.Drawing.Size(100, 20);
            this.txtLetrasIngresar.TabIndex = 5;
            // 
            // lblEscojaDificultad
            // 
            this.lblEscojaDificultad.AutoSize = true;
            this.lblEscojaDificultad.Location = new System.Drawing.Point(24, 93);
            this.lblEscojaDificultad.Name = "lblEscojaDificultad";
            this.lblEscojaDificultad.Size = new System.Drawing.Size(86, 13);
            this.lblEscojaDificultad.TabIndex = 6;
            this.lblEscojaDificultad.Text = "Escoja Dificultad";
            // 
            // lblPalabraFormandose
            // 
            this.lblPalabraFormandose.AutoSize = true;
            this.lblPalabraFormandose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabraFormandose.Location = new System.Drawing.Point(178, 239);
            this.lblPalabraFormandose.Name = "lblPalabraFormandose";
            this.lblPalabraFormandose.Size = new System.Drawing.Size(70, 20);
            this.lblPalabraFormandose.TabIndex = 7;
            this.lblPalabraFormandose.Text = "Palabra";
            // 
            // btnSeleccionarDificultad
            // 
            this.btnSeleccionarDificultad.Location = new System.Drawing.Point(288, 91);
            this.btnSeleccionarDificultad.Name = "btnSeleccionarDificultad";
            this.btnSeleccionarDificultad.Size = new System.Drawing.Size(123, 23);
            this.btnSeleccionarDificultad.TabIndex = 8;
            this.btnSeleccionarDificultad.Text = "Seleccionar Dificultad";
            this.btnSeleccionarDificultad.UseVisualStyleBackColor = true;
            this.btnSeleccionarDificultad.Click += new System.EventHandler(this.btnSeleccionarDificultad_Click);
            // 
            // lblExplicacion
            // 
            this.lblExplicacion.AutoSize = true;
            this.lblExplicacion.Location = new System.Drawing.Point(12, 135);
            this.lblExplicacion.Name = "lblExplicacion";
            this.lblExplicacion.Size = new System.Drawing.Size(399, 13);
            this.lblExplicacion.TabIndex = 9;
            this.lblExplicacion.Text = "Debe ingresar solo letras minusculas  y una sola letra  de lo contrario no funcio" +
    "nará ";
            // 
            // lblExplicacionIntentos
            // 
            this.lblExplicacionIntentos.AutoSize = true;
            this.lblExplicacionIntentos.Location = new System.Drawing.Point(75, 286);
            this.lblExplicacionIntentos.Name = "lblExplicacionIntentos";
            this.lblExplicacionIntentos.Size = new System.Drawing.Size(111, 13);
            this.lblExplicacionIntentos.TabIndex = 10;
            this.lblExplicacionIntentos.Text = "Intentos que quedan: ";
            // 
            // lblConteoIntentos
            // 
            this.lblConteoIntentos.AutoSize = true;
            this.lblConteoIntentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConteoIntentos.Location = new System.Drawing.Point(192, 286);
            this.lblConteoIntentos.Name = "lblConteoIntentos";
            this.lblConteoIntentos.Size = new System.Drawing.Size(16, 16);
            this.lblConteoIntentos.TabIndex = 11;
            this.lblConteoIntentos.Text = "0";
            // 
            // lblAhorcado
            // 
            this.lblAhorcado.AutoSize = true;
            this.lblAhorcado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAhorcado.Location = new System.Drawing.Point(138, 27);
            this.lblAhorcado.Name = "lblAhorcado";
            this.lblAhorcado.Size = new System.Drawing.Size(183, 25);
            this.lblAhorcado.TabIndex = 12;
            this.lblAhorcado.Text = "Juego Ahorcado";
            // 
            // lblResultadoJuego
            // 
            this.lblResultadoJuego.AutoSize = true;
            this.lblResultadoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoJuego.Location = new System.Drawing.Point(129, 332);
            this.lblResultadoJuego.Name = "lblResultadoJuego";
            this.lblResultadoJuego.Size = new System.Drawing.Size(19, 25);
            this.lblResultadoJuego.TabIndex = 13;
            this.lblResultadoJuego.Text = ".";
            // 
            // btnEmpezarDeNuevo
            // 
            this.btnEmpezarDeNuevo.Location = new System.Drawing.Point(315, 319);
            this.btnEmpezarDeNuevo.Name = "btnEmpezarDeNuevo";
            this.btnEmpezarDeNuevo.Size = new System.Drawing.Size(110, 23);
            this.btnEmpezarDeNuevo.TabIndex = 14;
            this.btnEmpezarDeNuevo.Text = "Empezar de Nuevo";
            this.btnEmpezarDeNuevo.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(435, 382);
            this.Controls.Add(this.btnEmpezarDeNuevo);
            this.Controls.Add(this.lblResultadoJuego);
            this.Controls.Add(this.lblAhorcado);
            this.Controls.Add(this.lblConteoIntentos);
            this.Controls.Add(this.lblExplicacionIntentos);
            this.Controls.Add(this.lblExplicacion);
            this.Controls.Add(this.btnSeleccionarDificultad);
            this.Controls.Add(this.lblPalabraFormandose);
            this.Controls.Add(this.lblEscojaDificultad);
            this.Controls.Add(this.txtLetrasIngresar);
            this.Controls.Add(this.btnIngresarLetra);
            this.Controls.Add(this.cmbDificultad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbDificultad;
        private System.Windows.Forms.Button btnIngresarLetra;
        private System.Windows.Forms.TextBox txtLetrasIngresar;
        private System.Windows.Forms.Label lblEscojaDificultad;
        private System.Windows.Forms.Label lblPalabraFormandose;
        private System.Windows.Forms.Button btnSeleccionarDificultad;
        private System.Windows.Forms.Label lblExplicacion;
        private System.Windows.Forms.Label lblExplicacionIntentos;
        private System.Windows.Forms.Label lblConteoIntentos;
        private System.Windows.Forms.Label lblAhorcado;
        private System.Windows.Forms.Label lblResultadoJuego;
        private System.Windows.Forms.Button btnEmpezarDeNuevo;
    }
}

