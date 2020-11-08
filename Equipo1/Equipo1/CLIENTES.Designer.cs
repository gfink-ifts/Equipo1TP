namespace Equipo1
{
    partial class CLIENTES
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
            this.btn_Ejecutar = new System.Windows.Forms.Button();
            this.rbn_Borrar = new System.Windows.Forms.RadioButton();
            this.rbn_Actualizar = new System.Windows.Forms.RadioButton();
            this.rbn_Leer = new System.Windows.Forms.RadioButton();
            this.rbn_Crear = new System.Windows.Forms.RadioButton();
            this.btn_salir = new System.Windows.Forms.Button();
            this.cbx_cliente = new System.Windows.Forms.ComboBox();
            this.txt_area = new System.Windows.Forms.TextBox();
            this.lbl_orden = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.txt_registro = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombrecontacto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_buscarcliente = new System.Windows.Forms.Button();
            this.txt_buscarcliente = new System.Windows.Forms.TextBox();
            this.cbx_nombrecontacto = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(111, 24);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(122, 25);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "CLIENTES";
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(47, 252);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(107, 23);
            this.btn_Ejecutar.TabIndex = 38;
            this.btn_Ejecutar.Text = "EJECUTAR";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click_1);
            // 
            // rbn_Borrar
            // 
            this.rbn_Borrar.AutoSize = true;
            this.rbn_Borrar.Location = new System.Drawing.Point(275, 89);
            this.rbn_Borrar.Name = "rbn_Borrar";
            this.rbn_Borrar.Size = new System.Drawing.Size(53, 17);
            this.rbn_Borrar.TabIndex = 36;
            this.rbn_Borrar.TabStop = true;
            this.rbn_Borrar.Text = "Borrar";
            this.rbn_Borrar.UseVisualStyleBackColor = true;
            this.rbn_Borrar.CheckedChanged += new System.EventHandler(this.rbn_Borrar_CheckedChanged);
            // 
            // rbn_Actualizar
            // 
            this.rbn_Actualizar.AutoSize = true;
            this.rbn_Actualizar.Location = new System.Drawing.Point(184, 89);
            this.rbn_Actualizar.Name = "rbn_Actualizar";
            this.rbn_Actualizar.Size = new System.Drawing.Size(71, 17);
            this.rbn_Actualizar.TabIndex = 35;
            this.rbn_Actualizar.TabStop = true;
            this.rbn_Actualizar.Text = "Actualizar";
            this.rbn_Actualizar.UseVisualStyleBackColor = true;
            this.rbn_Actualizar.CheckedChanged += new System.EventHandler(this.rbn_Actualizar_CheckedChanged);
            // 
            // rbn_Leer
            // 
            this.rbn_Leer.AutoSize = true;
            this.rbn_Leer.Location = new System.Drawing.Point(93, 89);
            this.rbn_Leer.Name = "rbn_Leer";
            this.rbn_Leer.Size = new System.Drawing.Size(46, 17);
            this.rbn_Leer.TabIndex = 34;
            this.rbn_Leer.TabStop = true;
            this.rbn_Leer.Text = "Leer";
            this.rbn_Leer.UseVisualStyleBackColor = true;
            this.rbn_Leer.CheckedChanged += new System.EventHandler(this.rbn_Leer_CheckedChanged);
            // 
            // rbn_Crear
            // 
            this.rbn_Crear.AutoSize = true;
            this.rbn_Crear.Location = new System.Drawing.Point(2, 89);
            this.rbn_Crear.Name = "rbn_Crear";
            this.rbn_Crear.Size = new System.Drawing.Size(50, 17);
            this.rbn_Crear.TabIndex = 33;
            this.rbn_Crear.TabStop = true;
            this.rbn_Crear.Text = "Crear";
            this.rbn_Crear.UseVisualStyleBackColor = true;
            this.rbn_Crear.CheckedChanged += new System.EventHandler(this.rbn_Crear_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(262, 252);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(107, 23);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // cbx_cliente
            // 
            this.cbx_cliente.FormattingEnabled = true;
            this.cbx_cliente.Location = new System.Drawing.Point(87, 112);
            this.cbx_cliente.Name = "cbx_cliente";
            this.cbx_cliente.Size = new System.Drawing.Size(273, 21);
            this.cbx_cliente.TabIndex = 61;
            this.cbx_cliente.SelectionChangeCommitted += new System.EventHandler(this.cbx_cliente_SelectionChangeCommitted);
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(87, 141);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(273, 20);
            this.txt_area.TabIndex = 59;
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orden.Location = new System.Drawing.Point(45, 145);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(40, 13);
            this.lbl_orden.TabIndex = 60;
            this.lbl_orden.Text = "AREA";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(87, 113);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(273, 20);
            this.txt_nombre.TabIndex = 55;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(26, 117);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(60, 13);
            this.lbl_cliente.TabIndex = 56;
            this.lbl_cliente.Text = "NOMBRE";
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(87, 192);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(273, 20);
            this.txt_registro.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "REGISTRO";
            // 
            // txt_nombrecontacto
            // 
            this.txt_nombrecontacto.Location = new System.Drawing.Point(87, 166);
            this.txt_nombrecontacto.Name = "txt_nombrecontacto";
            this.txt_nombrecontacto.Size = new System.Drawing.Size(273, 20);
            this.txt_nombrecontacto.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 63;
            this.label2.Text = "CONTACTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(374, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(560, 353);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(93, 336);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 19);
            this.button1.TabIndex = 67;
            this.button1.Text = "Mostrar todo los datos del cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_buscarcliente
            // 
            this.btn_buscarcliente.Location = new System.Drawing.Point(47, 296);
            this.btn_buscarcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_buscarcliente.Name = "btn_buscarcliente";
            this.btn_buscarcliente.Size = new System.Drawing.Size(116, 19);
            this.btn_buscarcliente.TabIndex = 68;
            this.btn_buscarcliente.Text = "Buscar Cliente";
            this.btn_buscarcliente.UseVisualStyleBackColor = true;
            this.btn_buscarcliente.Click += new System.EventHandler(this.btn_buscarcliente_Click);
            // 
            // txt_buscarcliente
            // 
            this.txt_buscarcliente.Location = new System.Drawing.Point(168, 296);
            this.txt_buscarcliente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_buscarcliente.Name = "txt_buscarcliente";
            this.txt_buscarcliente.Size = new System.Drawing.Size(76, 20);
            this.txt_buscarcliente.TabIndex = 69;
            // 
            // cbx_nombrecontacto
            // 
            this.cbx_nombrecontacto.FormattingEnabled = true;
            this.cbx_nombrecontacto.Location = new System.Drawing.Point(87, 166);
            this.cbx_nombrecontacto.Name = "cbx_nombrecontacto";
            this.cbx_nombrecontacto.Size = new System.Drawing.Size(273, 21);
            this.cbx_nombrecontacto.TabIndex = 70;
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(943, 376);
            this.Controls.Add(this.cbx_nombrecontacto);
            this.Controls.Add(this.txt_buscarcliente);
            this.Controls.Add(this.btn_buscarcliente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txt_registro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_nombrecontacto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_cliente);
            this.Controls.Add(this.txt_area);
            this.Controls.Add(this.lbl_orden);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.btn_Ejecutar);
            this.Controls.Add(this.rbn_Borrar);
            this.Controls.Add(this.rbn_Actualizar);
            this.Controls.Add(this.rbn_Leer);
            this.Controls.Add(this.rbn_Crear);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Name = "CLIENTES";
            this.Text = "CLIENTES";
            this.Load += new System.EventHandler(this.CLIENTES_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.Button btn_Ejecutar;
        private System.Windows.Forms.RadioButton rbn_Borrar;
        private System.Windows.Forms.RadioButton rbn_Actualizar;
        private System.Windows.Forms.RadioButton rbn_Leer;
        private System.Windows.Forms.RadioButton rbn_Crear;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ComboBox cbx_cliente;
        private System.Windows.Forms.TextBox txt_area;
        private System.Windows.Forms.Label lbl_orden;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.TextBox txt_registro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_nombrecontacto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_buscarcliente;
        private System.Windows.Forms.TextBox txt_buscarcliente;
        private System.Windows.Forms.ComboBox cbx_nombrecontacto;
    }
}