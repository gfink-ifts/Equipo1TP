namespace Equipo1
{
    partial class PRINCIPAL_2
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
            this.btn_ventas = new System.Windows.Forms.Button();
            this.btn_productos = new System.Windows.Forms.Button();
            this.btn_provincias = new System.Windows.Forms.Button();
            this.btn_contactos = new System.Windows.Forms.Button();
            this.btn_tipo_productos = new System.Windows.Forms.Button();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_clientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(104, 266);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 15;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Location = new System.Drawing.Point(12, 155);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Size = new System.Drawing.Size(202, 23);
            this.btn_ventas.TabIndex = 14;
            this.btn_ventas.Text = "VENTAS";
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_productos
            // 
            this.btn_productos.Location = new System.Drawing.Point(12, 185);
            this.btn_productos.Name = "btn_productos";
            this.btn_productos.Size = new System.Drawing.Size(202, 23);
            this.btn_productos.TabIndex = 13;
            this.btn_productos.Text = "PRODUCTOS Y SERVICIOS";
            this.btn_productos.UseVisualStyleBackColor = true;
            this.btn_productos.Click += new System.EventHandler(this.btn_productos_Click);
            // 
            // btn_provincias
            // 
            this.btn_provincias.Location = new System.Drawing.Point(12, 125);
            this.btn_provincias.Name = "btn_provincias";
            this.btn_provincias.Size = new System.Drawing.Size(202, 23);
            this.btn_provincias.TabIndex = 12;
            this.btn_provincias.Text = "PROVINCIAS";
            this.btn_provincias.UseVisualStyleBackColor = true;
            this.btn_provincias.Click += new System.EventHandler(this.btn_provincias_Click);
            // 
            // btn_contactos
            // 
            this.btn_contactos.Location = new System.Drawing.Point(12, 65);
            this.btn_contactos.Name = "btn_contactos";
            this.btn_contactos.Size = new System.Drawing.Size(202, 23);
            this.btn_contactos.TabIndex = 11;
            this.btn_contactos.Text = "CONTACTOS";
            this.btn_contactos.UseVisualStyleBackColor = true;
            this.btn_contactos.Click += new System.EventHandler(this.btn_contactos_Click);
            // 
            // btn_tipo_productos
            // 
            this.btn_tipo_productos.Location = new System.Drawing.Point(11, 215);
            this.btn_tipo_productos.Name = "btn_tipo_productos";
            this.btn_tipo_productos.Size = new System.Drawing.Size(203, 23);
            this.btn_tipo_productos.TabIndex = 10;
            this.btn_tipo_productos.Text = "TIPO PRODUCTOS Y SERVICIOS";
            this.btn_tipo_productos.UseVisualStyleBackColor = true;
            this.btn_tipo_productos.Click += new System.EventHandler(this.btn_tipo_productos_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(25, 20);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(172, 25);
            this.lbl_titulo.TabIndex = 9;
            this.lbl_titulo.Text = "MENU TABLAS";
            // 
            // btn_clientes
            // 
            this.btn_clientes.Location = new System.Drawing.Point(11, 95);
            this.btn_clientes.Name = "btn_clientes";
            this.btn_clientes.Size = new System.Drawing.Size(203, 23);
            this.btn_clientes.TabIndex = 8;
            this.btn_clientes.Text = "CLIENTES";
            this.btn_clientes.UseVisualStyleBackColor = true;
            this.btn_clientes.Click += new System.EventHandler(this.btn_clientes_Click);
            // 
            // PRINCIPAL_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(226, 291);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_ventas);
            this.Controls.Add(this.btn_productos);
            this.Controls.Add(this.btn_provincias);
            this.Controls.Add(this.btn_contactos);
            this.Controls.Add(this.btn_tipo_productos);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.btn_clientes);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "PRINCIPAL_2";
            this.Text = "TABLAS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button btn_ventas;
        private System.Windows.Forms.Button btn_productos;
        private System.Windows.Forms.Button btn_provincias;
        private System.Windows.Forms.Button btn_contactos;
        private System.Windows.Forms.Button btn_tipo_productos;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_clientes;
    }
}