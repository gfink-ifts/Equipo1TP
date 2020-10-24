namespace Equipo1
{
    partial class PROVINCIAS
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
			this.label1 = new System.Windows.Forms.Label();
			this.rbn_Crear = new System.Windows.Forms.RadioButton();
			this.rbn_Leer = new System.Windows.Forms.RadioButton();
			this.rbn_Actualizar = new System.Windows.Forms.RadioButton();
			this.rbn_Borrar = new System.Windows.Forms.RadioButton();
			this.txt_Provincias = new System.Windows.Forms.TextBox();
			this.btn_Ejecutar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_salir
			// 
			this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
			this.btn_salir.Location = new System.Drawing.Point(259, 176);
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
			this.lbl_titulo.Location = new System.Drawing.Point(112, 9);
			this.lbl_titulo.Name = "lbl_titulo";
			this.lbl_titulo.Size = new System.Drawing.Size(149, 25);
			this.lbl_titulo.TabIndex = 18;
			this.lbl_titulo.Text = "PROVINCIAS";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(62, 127);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 13);
			this.label1.TabIndex = 24;
			this.label1.Text = "Provincias";
			// 
			// rbn_Crear
			// 
			this.rbn_Crear.AutoSize = true;
			this.rbn_Crear.Location = new System.Drawing.Point(26, 77);
			this.rbn_Crear.Name = "rbn_Crear";
			this.rbn_Crear.Size = new System.Drawing.Size(50, 17);
			this.rbn_Crear.TabIndex = 25;
			this.rbn_Crear.TabStop = true;
			this.rbn_Crear.Text = "Crear";
			this.rbn_Crear.UseVisualStyleBackColor = true;
			// 
			// rbn_Leer
			// 
			this.rbn_Leer.AutoSize = true;
			this.rbn_Leer.Location = new System.Drawing.Point(117, 77);
			this.rbn_Leer.Name = "rbn_Leer";
			this.rbn_Leer.Size = new System.Drawing.Size(46, 17);
			this.rbn_Leer.TabIndex = 26;
			this.rbn_Leer.TabStop = true;
			this.rbn_Leer.Text = "Leer";
			this.rbn_Leer.UseVisualStyleBackColor = true;
			// 
			// rbn_Actualizar
			// 
			this.rbn_Actualizar.AutoSize = true;
			this.rbn_Actualizar.Location = new System.Drawing.Point(208, 77);
			this.rbn_Actualizar.Name = "rbn_Actualizar";
			this.rbn_Actualizar.Size = new System.Drawing.Size(71, 17);
			this.rbn_Actualizar.TabIndex = 27;
			this.rbn_Actualizar.TabStop = true;
			this.rbn_Actualizar.Text = "Actualizar";
			this.rbn_Actualizar.UseVisualStyleBackColor = true;
			// 
			// rbn_Borrar
			// 
			this.rbn_Borrar.AutoSize = true;
			this.rbn_Borrar.Location = new System.Drawing.Point(299, 77);
			this.rbn_Borrar.Name = "rbn_Borrar";
			this.rbn_Borrar.Size = new System.Drawing.Size(53, 17);
			this.rbn_Borrar.TabIndex = 28;
			this.rbn_Borrar.TabStop = true;
			this.rbn_Borrar.Text = "Borrar";
			this.rbn_Borrar.UseVisualStyleBackColor = true;
			// 
			// txt_Provincias
			// 
			this.txt_Provincias.Location = new System.Drawing.Point(148, 120);
			this.txt_Provincias.Name = "txt_Provincias";
			this.txt_Provincias.Size = new System.Drawing.Size(196, 20);
			this.txt_Provincias.TabIndex = 29;
			// 
			// btn_Ejecutar
			// 
			this.btn_Ejecutar.Location = new System.Drawing.Point(65, 176);
			this.btn_Ejecutar.Name = "btn_Ejecutar";
			this.btn_Ejecutar.Size = new System.Drawing.Size(107, 23);
			this.btn_Ejecutar.TabIndex = 30;
			this.btn_Ejecutar.Text = "EJECUTAR";
			this.btn_Ejecutar.UseVisualStyleBackColor = true;
			// 
			// PROVINCIAS
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.ClientSize = new System.Drawing.Size(414, 236);
			this.Controls.Add(this.btn_Ejecutar);
			this.Controls.Add(this.txt_Provincias);
			this.Controls.Add(this.rbn_Borrar);
			this.Controls.Add(this.rbn_Actualizar);
			this.Controls.Add(this.rbn_Leer);
			this.Controls.Add(this.rbn_Crear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_salir);
			this.Controls.Add(this.lbl_titulo);
			this.ForeColor = System.Drawing.Color.MidnightBlue;
			this.Name = "PROVINCIAS";
			this.Text = "PROVINCIAS";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.RadioButton rbn_Crear;
		private System.Windows.Forms.RadioButton rbn_Leer;
		private System.Windows.Forms.RadioButton rbn_Actualizar;
		private System.Windows.Forms.RadioButton rbn_Borrar;
		private System.Windows.Forms.TextBox txt_Provincias;
		private System.Windows.Forms.Button btn_Ejecutar;
	}
}