﻿namespace Equipo1
{
    partial class VENTAS
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
            this.gpx_CRUD = new System.Windows.Forms.GroupBox();
            this.rbn_borrar = new System.Windows.Forms.RadioButton();
            this.rbn_actualizar = new System.Windows.Forms.RadioButton();
            this.rbn_leer = new System.Windows.Forms.RadioButton();
            this.rbn_crear = new System.Windows.Forms.RadioButton();
            this.txt_fecha = new System.Windows.Forms.TextBox();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.lbl_servicio = new System.Windows.Forms.Label();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.cbx_cliente = new System.Windows.Forms.ComboBox();
            this.cbx_servicio = new System.Windows.Forms.ComboBox();
            this.dgw_ventas = new System.Windows.Forms.DataGridView();
            this.lbl_error_fecha = new System.Windows.Forms.Label();
            this.lbl_error_servicio = new System.Windows.Forms.Label();
            this.lbl_error_cliente = new System.Windows.Forms.Label();
            this.chx_fecha = new System.Windows.Forms.CheckBox();
            this.chx_cliente = new System.Windows.Forms.CheckBox();
            this.chx_servicios = new System.Windows.Forms.CheckBox();
            this.txt_oc = new System.Windows.Forms.TextBox();
            this.lbl_oc = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.btn_reportes = new System.Windows.Forms.Button();
            this.gpx_CRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ventas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(293, 388);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 17;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(155, 18);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(102, 25);
            this.lbl_titulo.TabIndex = 16;
            this.lbl_titulo.Text = "VENTAS";
            // 
            // gpx_CRUD
            // 
            this.gpx_CRUD.Controls.Add(this.rbn_borrar);
            this.gpx_CRUD.Controls.Add(this.rbn_actualizar);
            this.gpx_CRUD.Controls.Add(this.rbn_leer);
            this.gpx_CRUD.Controls.Add(this.rbn_crear);
            this.gpx_CRUD.Location = new System.Drawing.Point(12, 56);
            this.gpx_CRUD.Name = "gpx_CRUD";
            this.gpx_CRUD.Size = new System.Drawing.Size(388, 39);
            this.gpx_CRUD.TabIndex = 18;
            this.gpx_CRUD.TabStop = false;
            // 
            // rbn_borrar
            // 
            this.rbn_borrar.AutoSize = true;
            this.rbn_borrar.Enabled = false;
            this.rbn_borrar.Location = new System.Drawing.Point(307, 16);
            this.rbn_borrar.Name = "rbn_borrar";
            this.rbn_borrar.Size = new System.Drawing.Size(71, 17);
            this.rbn_borrar.TabIndex = 3;
            this.rbn_borrar.TabStop = true;
            this.rbn_borrar.Text = "BORRAR";
            this.rbn_borrar.UseVisualStyleBackColor = true;
            // 
            // rbn_actualizar
            // 
            this.rbn_actualizar.AutoSize = true;
            this.rbn_actualizar.Location = new System.Drawing.Point(185, 16);
            this.rbn_actualizar.Name = "rbn_actualizar";
            this.rbn_actualizar.Size = new System.Drawing.Size(92, 17);
            this.rbn_actualizar.TabIndex = 2;
            this.rbn_actualizar.TabStop = true;
            this.rbn_actualizar.Text = "ACTUALIZAR";
            this.rbn_actualizar.UseVisualStyleBackColor = true;
            this.rbn_actualizar.CheckedChanged += new System.EventHandler(this.rbn_actualizar_CheckedChanged);
            // 
            // rbn_leer
            // 
            this.rbn_leer.AutoSize = true;
            this.rbn_leer.Location = new System.Drawing.Point(102, 16);
            this.rbn_leer.Name = "rbn_leer";
            this.rbn_leer.Size = new System.Drawing.Size(53, 17);
            this.rbn_leer.TabIndex = 1;
            this.rbn_leer.TabStop = true;
            this.rbn_leer.Text = "LEER";
            this.rbn_leer.UseVisualStyleBackColor = true;
            this.rbn_leer.CheckedChanged += new System.EventHandler(this.rbn_leer_CheckedChanged);
            // 
            // rbn_crear
            // 
            this.rbn_crear.AutoSize = true;
            this.rbn_crear.Location = new System.Drawing.Point(10, 16);
            this.rbn_crear.Name = "rbn_crear";
            this.rbn_crear.Size = new System.Drawing.Size(62, 17);
            this.rbn_crear.TabIndex = 0;
            this.rbn_crear.TabStop = true;
            this.rbn_crear.Text = "CREAR";
            this.rbn_crear.UseVisualStyleBackColor = true;
            this.rbn_crear.CheckedChanged += new System.EventHandler(this.rbn_crear_CheckedChanged);
            // 
            // txt_fecha
            // 
            this.txt_fecha.Location = new System.Drawing.Point(99, 106);
            this.txt_fecha.Name = "txt_fecha";
            this.txt_fecha.Size = new System.Drawing.Size(301, 20);
            this.txt_fecha.TabIndex = 4;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(31, 110);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(47, 13);
            this.lbl_fecha.TabIndex = 5;
            this.lbl_fecha.Text = "FECHA";
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(19, 136);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(59, 13);
            this.lbl_cliente.TabIndex = 20;
            this.lbl_cliente.Text = "CLIENTE";
            // 
            // lbl_servicio
            // 
            this.lbl_servicio.AutoSize = true;
            this.lbl_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_servicio.Location = new System.Drawing.Point(13, 162);
            this.lbl_servicio.Name = "lbl_servicio";
            this.lbl_servicio.Size = new System.Drawing.Size(65, 13);
            this.lbl_servicio.TabIndex = 22;
            this.lbl_servicio.Text = "SERVICIO";
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_ejecutar.Location = new System.Drawing.Point(10, 388);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(107, 23);
            this.btn_ejecutar.TabIndex = 27;
            this.btn_ejecutar.Text = "EJECUTAR";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click);
            // 
            // cbx_cliente
            // 
            this.cbx_cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_cliente.FormattingEnabled = true;
            this.cbx_cliente.Location = new System.Drawing.Point(99, 132);
            this.cbx_cliente.Name = "cbx_cliente";
            this.cbx_cliente.Size = new System.Drawing.Size(301, 21);
            this.cbx_cliente.TabIndex = 29;
            // 
            // cbx_servicio
            // 
            this.cbx_servicio.FormattingEnabled = true;
            this.cbx_servicio.Location = new System.Drawing.Point(99, 158);
            this.cbx_servicio.Name = "cbx_servicio";
            this.cbx_servicio.Size = new System.Drawing.Size(301, 21);
            this.cbx_servicio.TabIndex = 30;
            // 
            // dgw_ventas
            // 
            this.dgw_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_ventas.Location = new System.Drawing.Point(12, 240);
            this.dgw_ventas.Name = "dgw_ventas";
            this.dgw_ventas.Size = new System.Drawing.Size(388, 142);
            this.dgw_ventas.TabIndex = 31;
            // 
            // lbl_error_fecha
            // 
            this.lbl_error_fecha.AutoSize = true;
            this.lbl_error_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_fecha.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_fecha.Location = new System.Drawing.Point(402, 108);
            this.lbl_error_fecha.Name = "lbl_error_fecha";
            this.lbl_error_fecha.Size = new System.Drawing.Size(15, 20);
            this.lbl_error_fecha.TabIndex = 32;
            this.lbl_error_fecha.Text = "*";
            // 
            // lbl_error_servicio
            // 
            this.lbl_error_servicio.AutoSize = true;
            this.lbl_error_servicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_servicio.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_servicio.Location = new System.Drawing.Point(402, 160);
            this.lbl_error_servicio.Name = "lbl_error_servicio";
            this.lbl_error_servicio.Size = new System.Drawing.Size(15, 20);
            this.lbl_error_servicio.TabIndex = 33;
            this.lbl_error_servicio.Text = "*";
            // 
            // lbl_error_cliente
            // 
            this.lbl_error_cliente.AutoSize = true;
            this.lbl_error_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_error_cliente.ForeColor = System.Drawing.Color.Crimson;
            this.lbl_error_cliente.Location = new System.Drawing.Point(402, 136);
            this.lbl_error_cliente.Name = "lbl_error_cliente";
            this.lbl_error_cliente.Size = new System.Drawing.Size(15, 20);
            this.lbl_error_cliente.TabIndex = 34;
            this.lbl_error_cliente.Text = "*";
            // 
            // chx_fecha
            // 
            this.chx_fecha.AutoSize = true;
            this.chx_fecha.Location = new System.Drawing.Point(81, 109);
            this.chx_fecha.Name = "chx_fecha";
            this.chx_fecha.Size = new System.Drawing.Size(15, 14);
            this.chx_fecha.TabIndex = 37;
            this.chx_fecha.UseVisualStyleBackColor = true;
            // 
            // chx_cliente
            // 
            this.chx_cliente.AutoSize = true;
            this.chx_cliente.Location = new System.Drawing.Point(81, 135);
            this.chx_cliente.Name = "chx_cliente";
            this.chx_cliente.Size = new System.Drawing.Size(15, 14);
            this.chx_cliente.TabIndex = 38;
            this.chx_cliente.UseVisualStyleBackColor = true;
            // 
            // chx_servicios
            // 
            this.chx_servicios.AutoSize = true;
            this.chx_servicios.Location = new System.Drawing.Point(81, 161);
            this.chx_servicios.Name = "chx_servicios";
            this.chx_servicios.Size = new System.Drawing.Size(15, 14);
            this.chx_servicios.TabIndex = 39;
            this.chx_servicios.UseVisualStyleBackColor = true;
            // 
            // txt_oc
            // 
            this.txt_oc.Location = new System.Drawing.Point(99, 185);
            this.txt_oc.Name = "txt_oc";
            this.txt_oc.Size = new System.Drawing.Size(301, 20);
            this.txt_oc.TabIndex = 40;
            // 
            // lbl_oc
            // 
            this.lbl_oc.AutoSize = true;
            this.lbl_oc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_oc.Location = new System.Drawing.Point(14, 189);
            this.lbl_oc.Name = "lbl_oc";
            this.lbl_oc.Size = new System.Drawing.Size(85, 13);
            this.lbl_oc.TabIndex = 41;
            this.lbl_oc.Text = "OR. COMPRA";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(99, 211);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(301, 20);
            this.txt_cantidad.TabIndex = 43;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(29, 215);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(70, 13);
            this.lbl_cantidad.TabIndex = 44;
            this.lbl_cantidad.Text = "CANTIDAD";
            // 
            // btn_reportes
            // 
            this.btn_reportes.ForeColor = System.Drawing.Color.Green;
            this.btn_reportes.Location = new System.Drawing.Point(150, 388);
            this.btn_reportes.Name = "btn_reportes";
            this.btn_reportes.Size = new System.Drawing.Size(107, 23);
            this.btn_reportes.TabIndex = 45;
            this.btn_reportes.Text = "REPORTES";
            this.btn_reportes.UseVisualStyleBackColor = true;
            this.btn_reportes.Click += new System.EventHandler(this.btn_reportes_Click);
            // 
            // VENTAS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(417, 417);
            this.Controls.Add(this.btn_reportes);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_oc);
            this.Controls.Add(this.lbl_oc);
            this.Controls.Add(this.chx_servicios);
            this.Controls.Add(this.chx_cliente);
            this.Controls.Add(this.chx_fecha);
            this.Controls.Add(this.lbl_error_cliente);
            this.Controls.Add(this.lbl_error_servicio);
            this.Controls.Add(this.lbl_error_fecha);
            this.Controls.Add(this.dgw_ventas);
            this.Controls.Add(this.cbx_servicio);
            this.Controls.Add(this.cbx_cliente);
            this.Controls.Add(this.btn_ejecutar);
            this.Controls.Add(this.lbl_servicio);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.txt_fecha);
            this.Controls.Add(this.lbl_fecha);
            this.Controls.Add(this.gpx_CRUD);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "VENTAS";
            this.Text = "VENTAS";
            this.Load += new System.EventHandler(this.VENTAS_Load);
            this.gpx_CRUD.ResumeLayout(false);
            this.gpx_CRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_ventas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.GroupBox gpx_CRUD;
        private System.Windows.Forms.RadioButton rbn_crear;
        private System.Windows.Forms.RadioButton rbn_leer;
        private System.Windows.Forms.RadioButton rbn_actualizar;
        private System.Windows.Forms.RadioButton rbn_borrar;
        private System.Windows.Forms.TextBox txt_fecha;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Label lbl_servicio;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.ComboBox cbx_cliente;
        private System.Windows.Forms.ComboBox cbx_servicio;
        private System.Windows.Forms.DataGridView dgw_ventas;
        private System.Windows.Forms.Label lbl_error_fecha;
        private System.Windows.Forms.Label lbl_error_servicio;
        private System.Windows.Forms.Label lbl_error_cliente;
        private System.Windows.Forms.CheckBox chx_fecha;
        private System.Windows.Forms.CheckBox chx_cliente;
        private System.Windows.Forms.CheckBox chx_servicios;
        private System.Windows.Forms.TextBox txt_oc;
        private System.Windows.Forms.Label lbl_oc;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Button btn_reportes;
    }
}