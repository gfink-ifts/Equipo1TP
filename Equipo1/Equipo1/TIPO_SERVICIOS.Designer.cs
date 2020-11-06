namespace Equipo1
{
    partial class TIPO_SERVICIOS
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
            this.cbx_descripcion = new System.Windows.Forms.ComboBox();
            this.btn_ejecutar = new System.Windows.Forms.Button();
            this.txt_descripcion1 = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.gpx_CRUD = new System.Windows.Forms.GroupBox();
            this.rbn_borrar = new System.Windows.Forms.RadioButton();
            this.rbn_actualizar = new System.Windows.Forms.RadioButton();
            this.rbn_leer = new System.Windows.Forms.RadioButton();
            this.rbn_crear = new System.Windows.Forms.RadioButton();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_mostrartodo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.gpx_CRUD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(149, 20);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(296, 31);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "TIPO DE SERVICIOS";
            // 
            // cbx_descripcion
            // 
            this.cbx_descripcion.FormattingEnabled = true;
            this.cbx_descripcion.Location = new System.Drawing.Point(188, 156);
            this.cbx_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_descripcion.Name = "cbx_descripcion";
            this.cbx_descripcion.Size = new System.Drawing.Size(363, 24);
            this.cbx_descripcion.TabIndex = 54;
            // 
            // btn_ejecutar
            // 
            this.btn_ejecutar.ForeColor = System.Drawing.Color.MediumBlue;
            this.btn_ejecutar.Location = new System.Drawing.Point(123, 230);
            this.btn_ejecutar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ejecutar.Name = "btn_ejecutar";
            this.btn_ejecutar.Size = new System.Drawing.Size(121, 28);
            this.btn_ejecutar.TabIndex = 53;
            this.btn_ejecutar.Text = "EJECUTAR";
            this.btn_ejecutar.UseVisualStyleBackColor = true;
            this.btn_ejecutar.Click += new System.EventHandler(this.btn_ejecutar_Click_1);
            // 
            // txt_descripcion1
            // 
            this.txt_descripcion1.Location = new System.Drawing.Point(165, 156);
            this.txt_descripcion1.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion1.Name = "txt_descripcion1";
            this.txt_descripcion1.Size = new System.Drawing.Size(363, 22);
            this.txt_descripcion1.TabIndex = 47;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(17, 161);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(111, 17);
            this.lbl_cliente.TabIndex = 48;
            this.lbl_cliente.Text = "DESCRIPCION";
            // 
            // gpx_CRUD
            // 
            this.gpx_CRUD.Controls.Add(this.rbn_borrar);
            this.gpx_CRUD.Controls.Add(this.rbn_actualizar);
            this.gpx_CRUD.Controls.Add(this.rbn_leer);
            this.gpx_CRUD.Controls.Add(this.rbn_crear);
            this.gpx_CRUD.Location = new System.Drawing.Point(33, 80);
            this.gpx_CRUD.Margin = new System.Windows.Forms.Padding(4);
            this.gpx_CRUD.Name = "gpx_CRUD";
            this.gpx_CRUD.Padding = new System.Windows.Forms.Padding(4);
            this.gpx_CRUD.Size = new System.Drawing.Size(509, 48);
            this.gpx_CRUD.TabIndex = 46;
            this.gpx_CRUD.TabStop = false;
            // 
            // rbn_borrar
            // 
            this.rbn_borrar.AutoSize = true;
            this.rbn_borrar.Location = new System.Drawing.Point(404, 20);
            this.rbn_borrar.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_borrar.Name = "rbn_borrar";
            this.rbn_borrar.Size = new System.Drawing.Size(88, 21);
            this.rbn_borrar.TabIndex = 3;
            this.rbn_borrar.TabStop = true;
            this.rbn_borrar.Text = "BORRAR";
            this.rbn_borrar.UseVisualStyleBackColor = true;
            this.rbn_borrar.CheckedChanged += new System.EventHandler(this.rbn_Eliminar_CheckedChanged);
            // 
            // rbn_actualizar
            // 
            this.rbn_actualizar.AutoSize = true;
            this.rbn_actualizar.Location = new System.Drawing.Point(247, 20);
            this.rbn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_actualizar.Name = "rbn_actualizar";
            this.rbn_actualizar.Size = new System.Drawing.Size(114, 21);
            this.rbn_actualizar.TabIndex = 2;
            this.rbn_actualizar.TabStop = true;
            this.rbn_actualizar.Text = "ACTUALIZAR";
            this.rbn_actualizar.UseVisualStyleBackColor = true;
            this.rbn_actualizar.CheckedChanged += new System.EventHandler(this.rbn_Actualizar_CheckedChanged);
            // 
            // rbn_leer
            // 
            this.rbn_leer.AutoSize = true;
            this.rbn_leer.Location = new System.Drawing.Point(136, 20);
            this.rbn_leer.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_leer.Name = "rbn_leer";
            this.rbn_leer.Size = new System.Drawing.Size(65, 21);
            this.rbn_leer.TabIndex = 1;
            this.rbn_leer.TabStop = true;
            this.rbn_leer.Text = "LEER";
            this.rbn_leer.UseVisualStyleBackColor = true;
            this.rbn_leer.CheckedChanged += new System.EventHandler(this.rbn_Leer_CheckedChanged);
            // 
            // rbn_crear
            // 
            this.rbn_crear.AutoSize = true;
            this.rbn_crear.Location = new System.Drawing.Point(13, 20);
            this.rbn_crear.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_crear.Name = "rbn_crear";
            this.rbn_crear.Size = new System.Drawing.Size(76, 21);
            this.rbn_crear.TabIndex = 0;
            this.rbn_crear.TabStop = true;
            this.rbn_crear.Text = "CREAR";
            this.rbn_crear.UseVisualStyleBackColor = true;
            this.rbn_crear.CheckedChanged += new System.EventHandler(this.rbn_Crear_CheckedChanged);
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(389, 230);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(143, 28);
            this.btn_salir.TabIndex = 45;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(641, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(573, 442);
            this.dataGridView1.TabIndex = 55;
            // 
            // btn_mostrartodo
            // 
            this.btn_mostrartodo.Location = new System.Drawing.Point(104, 437);
            this.btn_mostrartodo.Name = "btn_mostrartodo";
            this.btn_mostrartodo.Size = new System.Drawing.Size(359, 23);
            this.btn_mostrartodo.TabIndex = 56;
            this.btn_mostrartodo.Text = "Mostrar todos lo datos del tipo de producto";
            this.btn_mostrartodo.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(33, 385);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(180, 23);
            this.btn_buscar.TabIndex = 57;
            this.btn_buscar.Text = "Buscar tipo de producto";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(230, 386);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(100, 22);
            this.txt_buscar.TabIndex = 58;
            // 
            // TIPO_SERVICIOS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1226, 510);
            this.Controls.Add(this.txt_buscar);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.btn_mostrartodo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cbx_descripcion);
            this.Controls.Add(this.btn_ejecutar);
            this.Controls.Add(this.txt_descripcion1);
            this.Controls.Add(this.lbl_cliente);
            this.Controls.Add(this.gpx_CRUD);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.lbl_titulo);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TIPO_SERVICIOS";
            this.Text = "TIPO_SERVICIOS";
            this.Load += new System.EventHandler(this.TIPO_SERVICIOS_Load);
            this.gpx_CRUD.ResumeLayout(false);
            this.gpx_CRUD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_titulo;
        private System.Windows.Forms.ComboBox cbx_descripcion;
        private System.Windows.Forms.Button btn_ejecutar;
        private System.Windows.Forms.TextBox txt_descripcion1;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.GroupBox gpx_CRUD;
        private System.Windows.Forms.RadioButton rbn_borrar;
        private System.Windows.Forms.RadioButton rbn_actualizar;
        private System.Windows.Forms.RadioButton rbn_leer;
        private System.Windows.Forms.RadioButton rbn_crear;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_mostrartodo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.TextBox txt_buscar;
    }
}