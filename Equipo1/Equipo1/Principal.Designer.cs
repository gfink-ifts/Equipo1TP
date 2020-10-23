namespace Equipo1
{
    partial class PRINCIPAL
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
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_leer = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_consultas_reportes = new System.Windows.Forms.Button();
            this.btn_crear = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.Location = new System.Drawing.Point(11, 66);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(203, 23);
            this.btn_actualizar.TabIndex = 0;
            this.btn_actualizar.Text = "ACTUALIZAR";
            this.btn_actualizar.UseVisualStyleBackColor = true;
            this.btn_actualizar.Click += new System.EventHandler(this.btn_actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MENU PRINCIPAL";
            // 
            // btn_leer
            // 
            this.btn_leer.Location = new System.Drawing.Point(12, 96);
            this.btn_leer.Name = "btn_leer";
            this.btn_leer.Size = new System.Drawing.Size(202, 23);
            this.btn_leer.TabIndex = 3;
            this.btn_leer.Text = "LEER";
            this.btn_leer.UseVisualStyleBackColor = true;
            this.btn_leer.Click += new System.EventHandler(this.btn_leer_Click);
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.Location = new System.Drawing.Point(12, 126);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(202, 23);
            this.btn_eliminar.TabIndex = 4;
            this.btn_eliminar.Text = "ELIMINAR";
            this.btn_eliminar.UseVisualStyleBackColor = true;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // btn_consultas_reportes
            // 
            this.btn_consultas_reportes.Location = new System.Drawing.Point(12, 186);
            this.btn_consultas_reportes.Name = "btn_consultas_reportes";
            this.btn_consultas_reportes.Size = new System.Drawing.Size(202, 23);
            this.btn_consultas_reportes.TabIndex = 5;
            this.btn_consultas_reportes.Text = "CONSULTAS Y REPORTES";
            this.btn_consultas_reportes.UseVisualStyleBackColor = true;
            this.btn_consultas_reportes.Click += new System.EventHandler(this.btn_consultas_reportes_Click);
            // 
            // btn_crear
            // 
            this.btn_crear.Location = new System.Drawing.Point(12, 156);
            this.btn_crear.Name = "btn_crear";
            this.btn_crear.Size = new System.Drawing.Size(202, 23);
            this.btn_crear.TabIndex = 6;
            this.btn_crear.Text = "CREAR";
            this.btn_crear.UseVisualStyleBackColor = true;
            this.btn_crear.Click += new System.EventHandler(this.btn_crear_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(107, 228);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 7;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // PRINCIPAL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(227, 251);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_crear);
            this.Controls.Add(this.btn_consultas_reportes);
            this.Controls.Add(this.btn_eliminar);
            this.Controls.Add(this.btn_leer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_actualizar);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "PRINCIPAL";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.PRINCIPAL_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_leer;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_consultas_reportes;
        private System.Windows.Forms.Button btn_crear;
        private System.Windows.Forms.Button btn_salir;
    }
}

