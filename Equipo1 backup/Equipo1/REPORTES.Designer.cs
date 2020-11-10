namespace Equipo1
{
    partial class REPORTES
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
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.gpx_selector = new System.Windows.Forms.GroupBox();
            this.rbn_producto = new System.Windows.Forms.RadioButton();
            this.rbn_cliente = new System.Windows.Forms.RadioButton();
            this.rbn_fecha = new System.Windows.Forms.RadioButton();
            this.dgw_reportes = new System.Windows.Forms.DataGridView();
            this.lbl_mejor_nombre = new System.Windows.Forms.Label();
            this.lbl_mejor_total = new System.Windows.Forms.Label();
            this.lbl_mejor = new System.Windows.Forms.Label();
            this.lbl_peor_total = new System.Windows.Forms.Label();
            this.lbl_peor = new System.Windows.Forms.Label();
            this.lbl_peor_nombre = new System.Windows.Forms.Label();
            this.cbx_mes = new System.Windows.Forms.ComboBox();
            this.cbx_ano = new System.Windows.Forms.ComboBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.gbx_fecha = new System.Windows.Forms.GroupBox();
            this.rbn_producto_2 = new System.Windows.Forms.RadioButton();
            this.rbn_cliente_2 = new System.Windows.Forms.RadioButton();
            this.gpx_selector.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_reportes)).BeginInit();
            this.gbx_fecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(290, 10);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(135, 25);
            this.lbl_titulo.TabIndex = 10;
            this.lbl_titulo.Text = "REPORTES";
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(603, 427);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 18;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // gpx_selector
            // 
            this.gpx_selector.Controls.Add(this.rbn_producto);
            this.gpx_selector.Controls.Add(this.rbn_cliente);
            this.gpx_selector.Controls.Add(this.rbn_fecha);
            this.gpx_selector.Location = new System.Drawing.Point(31, 46);
            this.gpx_selector.Name = "gpx_selector";
            this.gpx_selector.Size = new System.Drawing.Size(340, 53);
            this.gpx_selector.TabIndex = 20;
            this.gpx_selector.TabStop = false;
            // 
            // rbn_producto
            // 
            this.rbn_producto.AutoSize = true;
            this.rbn_producto.Location = new System.Drawing.Point(233, 19);
            this.rbn_producto.Name = "rbn_producto";
            this.rbn_producto.Size = new System.Drawing.Size(86, 17);
            this.rbn_producto.TabIndex = 2;
            this.rbn_producto.TabStop = true;
            this.rbn_producto.Text = "PRODUCTO";
            this.rbn_producto.UseVisualStyleBackColor = true;
            this.rbn_producto.CheckedChanged += new System.EventHandler(this.rbn_producto_CheckedChanged);
            // 
            // rbn_cliente
            // 
            this.rbn_cliente.AutoSize = true;
            this.rbn_cliente.Location = new System.Drawing.Point(128, 19);
            this.rbn_cliente.Name = "rbn_cliente";
            this.rbn_cliente.Size = new System.Drawing.Size(70, 17);
            this.rbn_cliente.TabIndex = 1;
            this.rbn_cliente.TabStop = true;
            this.rbn_cliente.Text = "CLIENTE";
            this.rbn_cliente.UseVisualStyleBackColor = true;
            this.rbn_cliente.CheckedChanged += new System.EventHandler(this.rbn_cliente_CheckedChanged);
            // 
            // rbn_fecha
            // 
            this.rbn_fecha.AutoSize = true;
            this.rbn_fecha.Location = new System.Drawing.Point(28, 19);
            this.rbn_fecha.Name = "rbn_fecha";
            this.rbn_fecha.Size = new System.Drawing.Size(60, 17);
            this.rbn_fecha.TabIndex = 0;
            this.rbn_fecha.TabStop = true;
            this.rbn_fecha.Text = "FECHA";
            this.rbn_fecha.UseVisualStyleBackColor = true;
            this.rbn_fecha.CheckedChanged += new System.EventHandler(this.rbn_fecha_CheckedChanged);
            // 
            // dgw_reportes
            // 
            this.dgw_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_reportes.Location = new System.Drawing.Point(12, 239);
            this.dgw_reportes.Name = "dgw_reportes";
            this.dgw_reportes.Size = new System.Drawing.Size(698, 182);
            this.dgw_reportes.TabIndex = 33;
            // 
            // lbl_mejor_nombre
            // 
            this.lbl_mejor_nombre.AutoSize = true;
            this.lbl_mejor_nombre.Location = new System.Drawing.Point(84, 139);
            this.lbl_mejor_nombre.Name = "lbl_mejor_nombre";
            this.lbl_mejor_nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_mejor_nombre.TabIndex = 35;
            this.lbl_mejor_nombre.Text = "label1";
            // 
            // lbl_mejor_total
            // 
            this.lbl_mejor_total.AutoSize = true;
            this.lbl_mejor_total.Location = new System.Drawing.Point(84, 161);
            this.lbl_mejor_total.Name = "lbl_mejor_total";
            this.lbl_mejor_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_mejor_total.TabIndex = 39;
            this.lbl_mejor_total.Text = "label4";
            // 
            // lbl_mejor
            // 
            this.lbl_mejor.AutoSize = true;
            this.lbl_mejor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_mejor.Location = new System.Drawing.Point(40, 137);
            this.lbl_mejor.Name = "lbl_mejor";
            this.lbl_mejor.Size = new System.Drawing.Size(44, 15);
            this.lbl_mejor.TabIndex = 38;
            this.lbl_mejor.Text = "Mejor";
            // 
            // lbl_peor_total
            // 
            this.lbl_peor_total.AutoSize = true;
            this.lbl_peor_total.Location = new System.Drawing.Point(84, 206);
            this.lbl_peor_total.Name = "lbl_peor_total";
            this.lbl_peor_total.Size = new System.Drawing.Size(35, 13);
            this.lbl_peor_total.TabIndex = 42;
            this.lbl_peor_total.Text = "label4";
            // 
            // lbl_peor
            // 
            this.lbl_peor.AutoSize = true;
            this.lbl_peor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_peor.Location = new System.Drawing.Point(40, 182);
            this.lbl_peor.Name = "lbl_peor";
            this.lbl_peor.Size = new System.Drawing.Size(37, 15);
            this.lbl_peor.TabIndex = 41;
            this.lbl_peor.Text = "Peor";
            // 
            // lbl_peor_nombre
            // 
            this.lbl_peor_nombre.AutoSize = true;
            this.lbl_peor_nombre.Location = new System.Drawing.Point(84, 184);
            this.lbl_peor_nombre.Name = "lbl_peor_nombre";
            this.lbl_peor_nombre.Size = new System.Drawing.Size(35, 13);
            this.lbl_peor_nombre.TabIndex = 40;
            this.lbl_peor_nombre.Text = "label1";
            // 
            // cbx_mes
            // 
            this.cbx_mes.FormattingEnabled = true;
            this.cbx_mes.Items.AddRange(new object[] {
            "Todo",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbx_mes.Location = new System.Drawing.Point(99, 17);
            this.cbx_mes.Name = "cbx_mes";
            this.cbx_mes.Size = new System.Drawing.Size(77, 21);
            this.cbx_mes.TabIndex = 53;
            // 
            // cbx_ano
            // 
            this.cbx_ano.FormattingEnabled = true;
            this.cbx_ano.Items.AddRange(new object[] {
            "2016",
            "2017",
            "2018",
            "2019",
            "2020"});
            this.cbx_ano.Location = new System.Drawing.Point(9, 17);
            this.cbx_ano.Name = "cbx_ano";
            this.cbx_ano.Size = new System.Drawing.Size(84, 21);
            this.cbx_ano.TabIndex = 54;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(343, 105);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 55;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            this.btn_buscar.Click += new System.EventHandler(this.btn_buscar_Click);
            // 
            // gbx_fecha
            // 
            this.gbx_fecha.Controls.Add(this.rbn_producto_2);
            this.gbx_fecha.Controls.Add(this.rbn_cliente_2);
            this.gbx_fecha.Controls.Add(this.cbx_ano);
            this.gbx_fecha.Controls.Add(this.cbx_mes);
            this.gbx_fecha.Location = new System.Drawing.Point(377, 47);
            this.gbx_fecha.Name = "gbx_fecha";
            this.gbx_fecha.Size = new System.Drawing.Size(333, 53);
            this.gbx_fecha.TabIndex = 21;
            this.gbx_fecha.TabStop = false;
            // 
            // rbn_producto_2
            // 
            this.rbn_producto_2.AutoSize = true;
            this.rbn_producto_2.Location = new System.Drawing.Point(249, 19);
            this.rbn_producto_2.Name = "rbn_producto_2";
            this.rbn_producto_2.Size = new System.Drawing.Size(86, 17);
            this.rbn_producto_2.TabIndex = 2;
            this.rbn_producto_2.TabStop = true;
            this.rbn_producto_2.Text = "PRODUCTO";
            this.rbn_producto_2.UseVisualStyleBackColor = true;
            // 
            // rbn_cliente_2
            // 
            this.rbn_cliente_2.AutoSize = true;
            this.rbn_cliente_2.Location = new System.Drawing.Point(182, 19);
            this.rbn_cliente_2.Name = "rbn_cliente_2";
            this.rbn_cliente_2.Size = new System.Drawing.Size(70, 17);
            this.rbn_cliente_2.TabIndex = 1;
            this.rbn_cliente_2.TabStop = true;
            this.rbn_cliente_2.Text = "CLIENTE";
            this.rbn_cliente_2.UseVisualStyleBackColor = true;
            // 
            // REPORTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(719, 450);
            this.Controls.Add(this.gbx_fecha);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.lbl_peor_total);
            this.Controls.Add(this.dgw_reportes);
            this.Controls.Add(this.lbl_mejor_total);
            this.Controls.Add(this.gpx_selector);
            this.Controls.Add(this.lbl_peor);
            this.Controls.Add(this.lbl_peor_nombre);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_mejor);
            this.Controls.Add(this.lbl_mejor_nombre);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.MediumBlue;
            this.Name = "REPORTES";
            this.Text = "REPORTES";
            this.Load += new System.EventHandler(this.REPORTES_Load);
            this.gpx_selector.ResumeLayout(false);
            this.gpx_selector.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_reportes)).EndInit();
            this.gbx_fecha.ResumeLayout(false);
            this.gbx_fecha.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.GroupBox gpx_selector;
        private System.Windows.Forms.DataGridView dgw_reportes;
        private System.Windows.Forms.Label lbl_mejor_total;
        private System.Windows.Forms.Label lbl_mejor;
        private System.Windows.Forms.Label lbl_mejor_nombre;
        private System.Windows.Forms.RadioButton rbn_producto;
        private System.Windows.Forms.RadioButton rbn_cliente;
        private System.Windows.Forms.RadioButton rbn_fecha;
        private System.Windows.Forms.Label lbl_peor_total;
        private System.Windows.Forms.Label lbl_peor;
        private System.Windows.Forms.Label lbl_peor_nombre;
        private System.Windows.Forms.ComboBox cbx_mes;
        private System.Windows.Forms.ComboBox cbx_ano;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.GroupBox gbx_fecha;
        private System.Windows.Forms.RadioButton rbn_producto_2;
        private System.Windows.Forms.RadioButton rbn_cliente_2;
    }
}