namespace Equipo1
{
    partial class CONTACTOS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.btn_salir = new System.Windows.Forms.Button();
			this.lbl_titulo = new System.Windows.Forms.Label();
			this.btn_Ejecutar = new System.Windows.Forms.Button();
			this.rbn_Crear = new System.Windows.Forms.RadioButton();
			this.rbn_Leer = new System.Windows.Forms.RadioButton();
			this.rbn_Actualizar = new System.Windows.Forms.RadioButton();
			this.rbn_Borrar = new System.Windows.Forms.RadioButton();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txt_Nombre = new System.Windows.Forms.TextBox();
			this.txt_Domicilio = new System.Windows.Forms.TextBox();
			this.txt_Id_Provincia = new System.Windows.Forms.TextBox();
			this.txt_Telefono = new System.Windows.Forms.TextBox();
			this.txt_Mail = new System.Windows.Forms.TextBox();
			this.cbx_Nombre = new System.Windows.Forms.ComboBox();
			this.cbx_Id_Provincia = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// btn_salir
			// 
			this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
			this.btn_salir.Location = new System.Drawing.Point(275, 330);
			this.btn_salir.Name = "btn_salir";
			this.btn_salir.Size = new System.Drawing.Size(107, 23);
			this.btn_salir.TabIndex = 19;
			this.btn_salir.Text = "SALIR";
			this.btn_salir.UseVisualStyleBackColor = true;
			this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
			// 
			// lbl_titulo
			// 
			this.lbl_titulo.AutoSize = true;
			this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_titulo.Location = new System.Drawing.Point(125, 18);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(152, 25);
			this.lbl_titulo.TabIndex = 18;
			this.lbl_titulo.Text = "CONTACTOS";
			// 
			// btn_Ejecutar
			// 
			this.btn_Ejecutar.Location = new System.Drawing.Point(24, 330);
			this.btn_Ejecutar.Name = "btn_Ejecutar";
			this.btn_Ejecutar.Size = new System.Drawing.Size(75, 23);
			this.btn_Ejecutar.TabIndex = 20;
			this.btn_Ejecutar.Text = "EJECUTAR";
			this.btn_Ejecutar.UseVisualStyleBackColor = true;
			this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click);
			// 
			// rbn_Crear
			// 
			this.rbn_Crear.AutoSize = true;
			this.rbn_Crear.Location = new System.Drawing.Point(24, 79);
			this.rbn_Crear.Name = "rbn_Crear";
			this.rbn_Crear.Size = new System.Drawing.Size(50, 17);
			this.rbn_Crear.TabIndex = 21;
			this.rbn_Crear.TabStop = true;
			this.rbn_Crear.Text = "Crear";
			this.rbn_Crear.UseVisualStyleBackColor = true;
			this.rbn_Crear.CheckedChanged += new System.EventHandler(this.rbn_Crear_CheckedChanged);
			// 
			// rbn_Leer
			// 
			this.rbn_Leer.AutoSize = true;
			this.rbn_Leer.Location = new System.Drawing.Point(115, 79);
			this.rbn_Leer.Name = "rbn_Leer";
			this.rbn_Leer.Size = new System.Drawing.Size(46, 17);
			this.rbn_Leer.TabIndex = 22;
			this.rbn_Leer.TabStop = true;
			this.rbn_Leer.Text = "Leer";
			this.rbn_Leer.UseVisualStyleBackColor = true;
			this.rbn_Leer.CheckedChanged += new System.EventHandler(this.rbn_Leer_CheckedChanged);
			// 
			// rbn_Actualizar
			// 
			this.rbn_Actualizar.AutoSize = true;
			this.rbn_Actualizar.Location = new System.Drawing.Point(206, 79);
			this.rbn_Actualizar.Name = "rbn_Actualizar";
			this.rbn_Actualizar.Size = new System.Drawing.Size(71, 17);
			this.rbn_Actualizar.TabIndex = 23;
			this.rbn_Actualizar.TabStop = true;
			this.rbn_Actualizar.Text = "Actualizar";
			this.rbn_Actualizar.UseVisualStyleBackColor = true;
			this.rbn_Actualizar.CheckedChanged += new System.EventHandler(this.rbn_Actualizar_CheckedChanged);
			// 
			// rbn_Borrar
			// 
			this.rbn_Borrar.AutoSize = true;
			this.rbn_Borrar.Location = new System.Drawing.Point(297, 79);
			this.rbn_Borrar.Name = "rbn_Borrar";
			this.rbn_Borrar.Size = new System.Drawing.Size(53, 17);
			this.rbn_Borrar.TabIndex = 24;
			this.rbn_Borrar.TabStop = true;
			this.rbn_Borrar.Text = "Borrar";
			this.rbn_Borrar.UseVisualStyleBackColor = true;
			this.rbn_Borrar.CheckedChanged += new System.EventHandler(this.rbn_Borrar_CheckedChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(35, 121);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 13);
			this.label1.TabIndex = 25;
			this.label1.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(49, 13);
			this.label3.TabIndex = 27;
			this.label3.Text = "Domicilio";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(35, 205);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(66, 13);
			this.label4.TabIndex = 28;
			this.label4.Text = "Id_Provincia";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(35, 247);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(49, 13);
			this.label5.TabIndex = 29;
			this.label5.Text = "Telefono";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(35, 289);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(26, 13);
			this.label6.TabIndex = 30;
			this.label6.Text = "Mail";
			// 
			// txt_Nombre
			// 
			this.txt_Nombre.Location = new System.Drawing.Point(115, 114);
			this.txt_Nombre.Name = "txt_Nombre";
			this.txt_Nombre.Size = new System.Drawing.Size(221, 20);
			this.txt_Nombre.TabIndex = 31;
			// 
			// txt_Domicilio
			// 
			this.txt_Domicilio.Location = new System.Drawing.Point(115, 160);
			this.txt_Domicilio.Name = "txt_Domicilio";
			this.txt_Domicilio.Size = new System.Drawing.Size(221, 20);
			this.txt_Domicilio.TabIndex = 33;
			// 
			// txt_Id_Provincia
			// 
			this.txt_Id_Provincia.Location = new System.Drawing.Point(115, 202);
			this.txt_Id_Provincia.Name = "txt_Id_Provincia";
			this.txt_Id_Provincia.Size = new System.Drawing.Size(221, 20);
			this.txt_Id_Provincia.TabIndex = 34;
			// 
			// txt_Telefono
			// 
			this.txt_Telefono.Location = new System.Drawing.Point(115, 244);
			this.txt_Telefono.Name = "txt_Telefono";
			this.txt_Telefono.Size = new System.Drawing.Size(221, 20);
			this.txt_Telefono.TabIndex = 35;
			// 
			// txt_Mail
			// 
			this.txt_Mail.Location = new System.Drawing.Point(115, 286);
			this.txt_Mail.Name = "txt_Mail";
			this.txt_Mail.Size = new System.Drawing.Size(221, 20);
			this.txt_Mail.TabIndex = 36;
			// 
			// cbx_Nombre
			// 
			this.cbx_Nombre.FormattingEnabled = true;
			this.cbx_Nombre.Location = new System.Drawing.Point(352, 113);
			this.cbx_Nombre.Name = "cbx_Nombre";
			this.cbx_Nombre.Size = new System.Drawing.Size(221, 21);
			this.cbx_Nombre.TabIndex = 37;
			this.cbx_Nombre.SelectedIndexChanged += new System.EventHandler(this.cbx_Nombre_SelectedIndexChanged);
			// 
			// cbx_Id_Provincia
			// 
			this.cbx_Id_Provincia.FormattingEnabled = true;
			this.cbx_Id_Provincia.Location = new System.Drawing.Point(353, 201);
			this.cbx_Id_Provincia.Name = "cbx_Id_Provincia";
			this.cbx_Id_Provincia.Size = new System.Drawing.Size(220, 21);
			this.cbx_Id_Provincia.TabIndex = 38;
			// 
			// CONTACTOS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(787, 374);
			this.Controls.Add(this.cbx_Id_Provincia);
			this.Controls.Add(this.cbx_Nombre);
			this.Controls.Add(this.txt_Mail);
			this.Controls.Add(this.txt_Telefono);
			this.Controls.Add(this.txt_Id_Provincia);
			this.Controls.Add(this.txt_Domicilio);
			this.Controls.Add(this.txt_Nombre);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.rbn_Borrar);
			this.Controls.Add(this.rbn_Actualizar);
			this.Controls.Add(this.rbn_Leer);
			this.Controls.Add(this.rbn_Crear);
			this.Controls.Add(this.btn_Ejecutar);
			this.Controls.Add(this.btn_salir);
			this.Controls.Add(this.lbl_titulo);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Name = "CONTACTOS";
			this.Text = "CONTACTOS";
			this.Load += new System.EventHandler(this.CONTACTOS_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.Button btn_Ejecutar;
		private System.Windows.Forms.RadioButton rbn_Crear;
		private System.Windows.Forms.RadioButton rbn_Leer;
		private System.Windows.Forms.RadioButton rbn_Actualizar;
		private System.Windows.Forms.RadioButton rbn_Borrar;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_Nombre;
		private System.Windows.Forms.TextBox txt_Domicilio;
		private System.Windows.Forms.TextBox txt_Id_Provincia;
		private System.Windows.Forms.TextBox txt_Telefono;
		private System.Windows.Forms.TextBox txt_Mail;
		private System.Windows.Forms.ComboBox cbx_Nombre;
		private System.Windows.Forms.ComboBox cbx_Id_Provincia;
	}
}