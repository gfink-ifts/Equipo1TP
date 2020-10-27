using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Equipo1
{
    public partial class CONTACTOS : Form
    {
        string cadenaConnex = @"data source=DESKTOP-E2DA7HR\SQLEXPRESS; initial catalog='outsourcingv01'; integrated security=SSPI";
        SqlConnection cn;

        //formulario
        public CONTACTOS()
        {
            InitializeComponent();
        }

        private void CONTACTOS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConnex);
        }
        //funciones
        void Limpiar()
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Domicilio.Text = "";
            txt_Id_Provincia.Text = "";
            txt_Telefono.Text = "";
            txt_Mail.Text = "";
        }
        //botones
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
		{
            if (rbn_Crear.Checked)
			{
                if (txt_Nombre.Text == ""||txt_Domicilio.Text == ""||txt_Telefono.Text == ""||txt_Mail.Text=="")
				{
                    MessageBox.Show ("Por favor completar todos los campos");
                }
				else 
                {
                    string nombre = txt_Nombre.Text;
                    string domicilio = txt_Domicilio.Text;
                    string telefono = txt_Telefono.Text;
                    string mail = txt_Mail.Text;

                    string cmd = "insert into CONTACTOS  (nombre,domicilio,telefono,mail) " + "values (@nom, @dom, @tel, @mail)";
                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@dom", domicilio);
                    comando.Parameters.AddWithValue("@tel", telefono);
                    comando.Parameters.AddWithValue("@mail", mail);

                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("contacto creado correctamente");
                    Limpiar();
                }   
            }
            if (rbn_Leer.Checked)
			{
                string nombre = txt_Nombre.Text;
                string domicilio = txt_Domicilio.Text;
                string telefono = txt_Telefono.Text;
                string mail = txt_Mail.Text;

                string cmd = "insert into CONTACTOS  (nombre,domicilio,telefono,mail) " + "values (@nom, @dom, @tel, @mail)";
                SqlCommand comando = new SqlCommand(cmd, cn);

                comando.Parameters.AddWithValue("@nom", nombre);
                comando.Parameters.AddWithValue("@dom", domicilio);
                comando.Parameters.AddWithValue("@tel", telefono);
                comando.Parameters.AddWithValue("@mail", mail);

                cn.Open();
                comando.ExecuteNonQuery();
                cn.Close();
                MessageBox.Show("contacto creado correctamente");
                Limpiar()

            }

        }

		private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Nombre.Enabled = false;
		}

		private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Id_Provincia.Enabled = false;
		}

		private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Id_Provincia.Enabled = false;
        }
	}
}
