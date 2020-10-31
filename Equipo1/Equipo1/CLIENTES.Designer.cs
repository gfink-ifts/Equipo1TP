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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titulo.Location = new System.Drawing.Point(148, 30);
            this.lbl_titulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(156, 31);
            this.lbl_titulo.TabIndex = 18;
            this.lbl_titulo.Text = "CLIENTES";
            // 
            // btn_Ejecutar
            // 
            this.btn_Ejecutar.Location = new System.Drawing.Point(63, 310);
            this.btn_Ejecutar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Ejecutar.Name = "btn_Ejecutar";
            this.btn_Ejecutar.Size = new System.Drawing.Size(143, 28);
            this.btn_Ejecutar.TabIndex = 38;
            this.btn_Ejecutar.Text = "EJECUTAR";
            this.btn_Ejecutar.UseVisualStyleBackColor = true;
            this.btn_Ejecutar.Click += new System.EventHandler(this.btn_Ejecutar_Click_1);
            // 
            // rbn_Borrar
            // 
            this.rbn_Borrar.AutoSize = true;
            this.rbn_Borrar.Location = new System.Drawing.Point(367, 109);
            this.rbn_Borrar.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Borrar.Name = "rbn_Borrar";
            this.rbn_Borrar.Size = new System.Drawing.Size(69, 21);
            this.rbn_Borrar.TabIndex = 36;
            this.rbn_Borrar.TabStop = true;
            this.rbn_Borrar.Text = "Borrar";
            this.rbn_Borrar.UseVisualStyleBackColor = true;
            // 
            // rbn_Actualizar
            // 
            this.rbn_Actualizar.AutoSize = true;
            this.rbn_Actualizar.Location = new System.Drawing.Point(245, 109);
            this.rbn_Actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Actualizar.Name = "rbn_Actualizar";
            this.rbn_Actualizar.Size = new System.Drawing.Size(91, 21);
            this.rbn_Actualizar.TabIndex = 35;
            this.rbn_Actualizar.TabStop = true;
            this.rbn_Actualizar.Text = "Actualizar";
            this.rbn_Actualizar.UseVisualStyleBackColor = true;
            // 
            // rbn_Leer
            // 
            this.rbn_Leer.AutoSize = true;
            this.rbn_Leer.Location = new System.Drawing.Point(124, 109);
            this.rbn_Leer.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Leer.Name = "rbn_Leer";
            this.rbn_Leer.Size = new System.Drawing.Size(58, 21);
            this.rbn_Leer.TabIndex = 34;
            this.rbn_Leer.TabStop = true;
            this.rbn_Leer.Text = "Leer";
            this.rbn_Leer.UseVisualStyleBackColor = true;
            // 
            // rbn_Crear
            // 
            this.rbn_Crear.AutoSize = true;
            this.rbn_Crear.Location = new System.Drawing.Point(3, 109);
            this.rbn_Crear.Margin = new System.Windows.Forms.Padding(4);
            this.rbn_Crear.Name = "rbn_Crear";
            this.rbn_Crear.Size = new System.Drawing.Size(64, 21);
            this.rbn_Crear.TabIndex = 33;
            this.rbn_Crear.TabStop = true;
            this.rbn_Crear.Text = "Crear";
            this.rbn_Crear.UseVisualStyleBackColor = true;
            // 
            // btn_salir
            // 
            this.btn_salir.ForeColor = System.Drawing.Color.Crimson;
            this.btn_salir.Location = new System.Drawing.Point(349, 310);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(143, 28);
            this.btn_salir.TabIndex = 31;
            this.btn_salir.Text = "SALIR";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click_1);
            // 
            // cbx_cliente
            // 
            this.cbx_cliente.FormattingEnabled = true;
            this.cbx_cliente.Location = new System.Drawing.Point(124, 138);
            this.cbx_cliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbx_cliente.Name = "cbx_cliente";
            this.cbx_cliente.Size = new System.Drawing.Size(363, 24);
            this.cbx_cliente.TabIndex = 61;
            this.cbx_cliente.SelectionChangeCommitted += new System.EventHandler(this.cbx_cliente_SelectionChangeCommitted);
            // 
            // txt_area
            // 
            this.txt_area.Location = new System.Drawing.Point(116, 174);
            this.txt_area.Margin = new System.Windows.Forms.Padding(4);
            this.txt_area.Name = "txt_area";
            this.txt_area.Size = new System.Drawing.Size(363, 22);
            this.txt_area.TabIndex = 59;
            // 
            // lbl_orden
            // 
            this.lbl_orden.AutoSize = true;
            this.lbl_orden.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_orden.Location = new System.Drawing.Point(60, 179);
            this.lbl_orden.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_orden.Name = "lbl_orden";
            this.lbl_orden.Size = new System.Drawing.Size(49, 17);
            this.lbl_orden.TabIndex = 60;
            this.lbl_orden.Text = "AREA";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(116, 139);
            this.txt_nombre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(363, 22);
            this.txt_nombre.TabIndex = 55;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cliente.Location = new System.Drawing.Point(34, 144);
            this.lbl_cliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(74, 17);
            this.lbl_cliente.TabIndex = 56;
            this.lbl_cliente.Text = "NOMBRE";
            // 
            // txt_registro
            // 
            this.txt_registro.Location = new System.Drawing.Point(116, 236);
            this.txt_registro.Margin = new System.Windows.Forms.Padding(4);
            this.txt_registro.Name = "txt_registro";
            this.txt_registro.Size = new System.Drawing.Size(363, 22);
            this.txt_registro.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 241);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 65;
            this.label1.Text = "REGISTRO";
            // 
            // txt_nombrecontacto
            // 
            this.txt_nombrecontacto.Location = new System.Drawing.Point(116, 204);
            this.txt_nombrecontacto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombrecontacto.Name = "txt_nombrecontacto";
            this.txt_nombrecontacto.Size = new System.Drawing.Size(363, 22);
            this.txt_nombrecontacto.TabIndex = 62;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 209);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 63;
            this.label2.Text = "CONTACTO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(499, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(746, 435);
            this.dataGridView1.TabIndex = 66;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(124, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 23);
            this.button1.TabIndex = 67;
            this.button1.Text = "Mostrar todo los datos del cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CLIENTES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1257, 463);
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
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}