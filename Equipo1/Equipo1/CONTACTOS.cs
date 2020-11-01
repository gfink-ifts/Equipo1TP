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
        string cadenaConnex = @"data source=DESKTOP-E2DA7HR\SQLEXPRESS; initial catalog='outsourcing'; integrated security=SSPI";
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
            txt_Domicilio.Text = "";
            txt_Id_Provincia.Text = "";
            txt_Telefono.Text = "";
            txt_Mail.Text = "";
        }
        void mostrar_nombre()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            cn.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT id_contacto,nombre FROM contactos", cn);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_Nombre.DataSource = data;
            cbx_Nombre.ValueMember = "id_contacto"; //VARIABLE VISIBLE
            cbx_Nombre.DisplayMember = "nombre"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            cn.Close();
        }
        void mostrar_provincia()
		{
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            cn.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT id_provincia,provincia FROM provincias", cn);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_Id_Provincia.DataSource = data;
            cbx_Id_Provincia.ValueMember = "id_provincia"; //VARIABLE VISIBLE
            cbx_Id_Provincia.DisplayMember = "provincia"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            cn.Close();
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
                  
                    //DECLARACION DE VARIABLES

                    string nombre =txt_Nombre.Text;
                    string domicilio = txt_Domicilio.Text;
                    string id_provincia = txt_Domicilio.Text;
                    int telefono = Convert.ToInt32(txt_Telefono.Text);
                    string mail = txt_Mail.Text;

                    string cmd = "insert into CONTACTOS  (nombre,domicilio,id_provincia,telefono,mail) " 
                        + "values (@nom, @dom,@id_prov, @tel, @mail)";


                    //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@dom", domicilio);
                    comando.Parameters.AddWithValue("@id_prov", id_provincia);
                    comando.Parameters.AddWithValue("@tel", telefono);
                    comando.Parameters.AddWithValue("@mail", mail);

                    cn.Open();

                    comando.ExecuteNonQuery();

                    cn.Close();
                   
                    MessageBox.Show("contacto creado correctamente");
                } 
            }
            //rbn_leer se borraria
            if (rbn_Leer.Checked)
			{
                /*
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
                */
            }
            if (rbn_Actualizar.Checked)
			{
               
                string nombre = Convert.ToString(txt_Nombre.Text);
                string domicilio = Convert.ToString(txt_Domicilio.Text);
                string telefono = Convert.ToString(txt_Telefono.Text);
                string mail = Convert.ToString(txt_Mail.Text);

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                SqlCommand actualizar_registro = new SqlCommand("UPDATE contactos SET nombre=@nom, domicilio=@dom, telefono=@tel, mail=@mail" +
                "WHERE id_contactos=@id", cn);

                //VINCULACION DE PARAMETROS
                actualizar_registro.Parameters.AddWithValue("@nom", nombre);
                actualizar_registro.Parameters.AddWithValue("@dom", domicilio);
                actualizar_registro.Parameters.AddWithValue("@tel", telefono);
                actualizar_registro.Parameters.AddWithValue("@mail", mail);
                //ABRO LA CONEXION
                cn.Open();

                //EJECUTO LA QUERY
                actualizar_registro.ExecuteNonQuery();

                //CIERRO LA CONEXION
                cn.Close();

                MessageBox.Show("Actualizo el registro.");

                Limpiar();
            }
           
        }
        //carga los cbx segun combo box
		private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
		{
            txt_Nombre.Enabled = true;
            txt_Domicilio.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Mail.Enabled = true;
            cbx_Nombre.Visible  =false;
            mostrar_provincia();

            
        }

		private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Id_Provincia.Enabled = false;
		}

		private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
		{
            txt_Nombre.Enabled = false;
            txt_Domicilio.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Mail.Enabled = true;
            cbx_Id_Provincia.Enabled = true;
            cbx_Nombre.Enabled = true;
            mostrar_nombre();
            mostrar_provincia();
        }

		private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
		{
            txt_Nombre.Enabled = false;
            txt_Domicilio.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Mail.Enabled = false;
            cbx_Id_Provincia.Enabled = false;
            cbx_Nombre.Enabled = true;
        }

		private void cbx_Nombre_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
