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
        string cadenaConnex = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        SqlConnection cn;

        //FUNCIONES
        void Limpiar()
        {
            txt_Provincias.Text = "";

        }
        //carga de combobox
        void mostrar_provincias()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            cn.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT id_provincia,provincia FROM PROVINCIAS", cn);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_Provincias.DataSource = data;
            cbx_Provincias.ValueMember = "id_provincia"; //VARIABLE VISIBLE
            cbx_Provincias.DisplayMember = "provincia"; //VARIABLE DESPLEGADA
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
            rbn_Crear.Enabled = false;
            rbn_Actualizar.Enabled = false;
            rbn_Borrar.Enabled = false;
            rbn_Leer.Checked = true;
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
                string provincia = txt_Provincias.Text;
                
               // int index = cbx_Provincias.SelectedIndex;
                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                SqlCommand actualizar = new SqlCommand("UPDATE provincias SET provincia=@prov where id_provincia like provincia ", cn);

                //VINCULACION DE PARAMETROS
                actualizar.Parameters.AddWithValue("@prov", provincia);
                

                //ABRO LA CONEXION
                cn.Open();

                //EJECUTO LA QUERY
                actualizar.ExecuteNonQuery();

                //CIERRO LA CONEXION
                cn.Close();

                MessageBox.Show("se actualizo el registro correctamente.");

            }
            if (rbn_Borrar.Checked)
            {
                ///DECLARACION DE VARIABLES
                string id = cbx_Provincias.SelectedValue.ToString();

                //CREACION DE LA VARIABLE: BORRAR
                SqlCommand borrar_registro = new SqlCommand();

                //VARIABLE + CONEXION
                borrar_registro = cn.CreateCommand();

                //INSTRUCCION SQL
                borrar_registro.CommandText = "DELETE FROM provincias WHERE id_provincia=@ID";

                //VINCULACION DE PARAMETROS
                borrar_registro.Parameters.AddWithValue("@ID", id);

                //ABRO LA CONEXION
                cn.Open();

                //EJECUTO LA INSTRUCION SQL
                borrar_registro.ExecuteNonQuery();

                //CIERRO LA CONEXION
                cn.Close();

                //MENSAJE DE VERIFICACION
                MessageBox.Show("se borro el registro correctamente");
            }
        }

        //SELECTOR
		private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
		{
            txt_Provincias.Visible = false;
            cbx_Provincias.Visible = true;
            mostrar_provincias();
        }

		private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Provincias.Visible  = false;
            txt_Provincias.Visible = true;
        }

		private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Provincias.Visible = true;
            txt_Provincias.Visible = true;
            mostrar_provincias();
        }

		private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
		{
            cbx_Provincias.Visible  = true;
            txt_Provincias.Visible  = false;
            mostrar_provincias();
        }
	}
}
