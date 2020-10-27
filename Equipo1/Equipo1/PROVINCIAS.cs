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
    public partial class PROVINCIAS : Form
    {
        string cadenaConnex = @"data source=DESKTOP-E2DA7HR\SQLEXPRESS; initial catalog='outsourcingv01'; integrated security=SSPI";
        SqlConnection cn;

        //FUNCIONES
        void Limpiar()
        {
            txt_Provincias.Text = "";

        }

        void mostrar_provincias()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            cn.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT id_provicia, nombre FROM PROVINCIAS", cn);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_Provincias.DataSource = data;
            cbx_Provincias.ValueMember = "id_provicia"; //VARIABLE VISIBLE
            cbx_Provincias.DisplayMember = "nombre"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            cn.Close();
        }
        
        //FORMULARIO
        public PROVINCIAS()
        {
            InitializeComponent();
        }

        private void PROVINCIAS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConnex);

        }


        //BOTONES
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void btn_Ejecutar_Click(object sender, EventArgs e)
		{
            if (rbn_Crear.Checked)
            {
                

                if (txt_Provincias.Text == "")
                {
                    MessageBox.Show("Por favor completar todos los campos");
                }
                else
                {
                    string Provincia = txt_Provincias.Text;
                    string cmd = "insert into PROVINCIAS (provincia) " + "values (  @prov)";


                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@prov", Provincia);


                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();


                    MessageBox.Show("Provincia creada correctamente");
                    Limpiar();
                }

            }
            if (rbn_Leer.Checked)
            {
                {
                    string Provincia = txt_Provincias.Text;
                    string cmd = "select * from  PROVINCIAS (provincia) " + "values (  @prov)";


                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@prov", Provincia);
                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();
                    Limpiar();
                }

            }
            if (rbn_Actualizar.Checked)
            {
                if (txt_Provincias.Text == "")
                {
                    MessageBox.Show("Por favor ingresar un dato para poder actualizar");
                }
                else
                {
                    string Provincia = txt_Provincias.Text;
                    string query = "UPDATE PROVINCIA SET nombre = @prov WHERE nombre like @prov";
                    SqlCommand comando = new SqlCommand(query, cn);
                    comando.Parameters.AddWithValue("@prov", Provincia);

                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();
                    Limpiar();
                    MessageBox.Show("actualizacion exitosa");
                }


            }
            if (rbn_Borrar.Checked)
            {
                if (txt_Provincias.Text == "")
                {
                    MessageBox.Show("Por favor ingrese la provincia que desea eliminar ");
                }
                else
                {
                    string Provincia = txt_Provincias.Text;
                    if (txt_Provincias.Text != "")
                    {
                        int id_cliente = Convert.ToInt32(txt_Provincias.Text);
                        string instruccion = "DELETE clientes WHERE id_cliente = @id";
                        SqlCommand comando = new SqlCommand(instruccion, cn);
                        comando.Parameters.AddWithValue("@prov", Provincia);
                        cn.Open();
                        comando.ExecuteNonQuery();
                        cn.Close();
                        Limpiar();

                        MessageBox.Show("provincia eliminada correctamente ");
                    }
                }
            }
        }

        //SELECTOR
		private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
		{
            txt_Provincias.Enabled = false;
            mostrar_provincias();
        }

		private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Provincias.Enabled = false;
		}

		private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
		{

		}

		private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
		{
            txt_Provincias.Enabled = false;
        }
	}
}
