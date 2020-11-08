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
    public partial class TIPO_SERVICIOS : Form
    {

        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIO *******************
        public TIPO_SERVICIOS()
        {
            InitializeComponent();
        }

        private void TIPO_SERVICIOS_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);
            rbn_actualizar.Enabled = false;
        }

        //BOTON: EJECUTAR
        private void btn_ejecutar_Click_1(object sender, EventArgs e)
        {
            {
                //CRUD: CREAR
                if (rbn_crear.Checked)
                {
                    alta_tiposervicio();
                    //llenar_datagrid();
                }
                //CRUD: LEER
                if (rbn_leer.Checked)
                {
                }
                //CRUD: UPDATE
                if (rbn_actualizar.Checked)
                {
                    actualizar();
                    /*

                    SqlDataAdapter llenar_combo;

                    DataTable tabla_cat_cliente = new DataTable();

                    mi_conexion.Open();

                    mostrar_por = new SqlDataAdapter("select * from clientes where direccion LIKE '%" + buscar + "%'", mi_conexion);

                    mostrar_por.Fill(tabla_cat_cliente);

                    mi_conexion.Close();
                    */


                }
                //CRUD: DELETE
                if (rbn_borrar.Checked)
                {
                    eliminar();
                }
            }
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            /*string apellido = txt_cliente.Text;*/
            string nombre = txt_buscar.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string consulta = "select t.descripcion_tipo_servicio,s.descripcion,s.precios from tipo_servicios as t, servicios as s where t.id_tipo_servicios = s.id_tipo_servicios and t.descripcion_tipo_servicio like @nombre";
            da = new SqlDataAdapter(consulta, mi_conexion);
            /*da.SelectCommand.Parameters.AddWithValue("@apell", "%" + apellido + "%" );*/
            da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mi_conexion.Close();
        }

        private void btn_mostrartodo_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string query = "select t.descripcion_tipo_servicio,s.descripcion,s.precios from tipo_servicios as t, servicios as s where t.id_tipo_servicios = s.id_tipo_servicios";

            da = new SqlDataAdapter(query, mi_conexion);

            da.Fill(dt);

            mi_conexion.Close();

            dataGridView1.DataSource = dt;
        }



        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
            cbx_descripcion.Visible = false;
            txt_descripcion1.Enabled = true;
            btn_ejecutar.Visible = true;
            Limpiar();
            
        }

        private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
            btn_ejecutar.Visible = false;
            cbx_descripcion.Visible = false;
            txt_descripcion1.Enabled = false;
        }
        private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
            cbx_descripcion.Visible = false;
            txt_descripcion1.Enabled = false;
            btn_ejecutar.Visible = false;
            

        }

        private void rbn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
            txt_descripcion1.Enabled = true;
            btn_ejecutar.Visible = true;

        }
        //FUNCIONES
        //**********************************************************************************************************

        //FUNCION LIMPIAR
        void Limpiar()
        {

            txt_descripcion1.Text = "";

        }

        //FUNCION LLENAR DATAGRID
        void llenar_datagrid()
        {

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string query = "select t.descripcion_tipo_servicio,s.descripcion,s.precios from tipo_servicios as t, servicios as s where t.id_tipo_servicios = s.id_tipo_servicios ";

            da = new SqlDataAdapter(query, mi_conexion);

            da.Fill(dt);

            mi_conexion.Close();

            dataGridView1.DataSource = dt;

        }

        //FUNCION Alta CLIENTES
        void alta_tiposervicio()
        {
            if (validartextbox())
            {
                string descripcion;
                mi_conexion.Open();
                descripcion = txt_descripcion1.Text;
               // area = txt_area.Text;
                //registro = txt_registro.Text;

                string cmd = "insert into tipo_servicios (descripcion_tipo_servicio) " +
                                "values ( @descripcion_tipo_servicio)";


                SqlCommand comando = new SqlCommand(cmd, mi_conexion);
                comando.Parameters.AddWithValue("@descripcion_tipo_servicio", descripcion);
               // comando.Parameters.AddWithValue("@area", area);
                //comando.Parameters.AddWithValue("@fecha_registro", registro);


                comando.ExecuteNonQuery();
                mi_conexion.Close();
                mostrarMensaje("Tipo de Servicio dado de alta correctamente");


            }
            else
            {
                mostrarMensaje("Por favor completar el campo Tipo de Servicio");
            }
            llenar_datagrid();
            // limpiarForm();

        }
        //FUNCION VALIDAS TEXBOX
        private bool validartextbox()
        {
            bool respuesta = true;


            if (txt_descripcion1.Text == "" )
            {
                respuesta = false;
            }
            else
            {

            }


            return respuesta;
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        //FUNCION ACTUALIZAR
        void actualizar()
        {
            if (validartextbox())
            {
                string nombre = txt_descripcion1.Text;
                //string area = txt_area.Text;


                string cmd = "update tipo_servicios set descripcion_tipo_servicio=@descripcion_tipo_servicio where descripcion_tipo_servicio like @id";
                mi_conexion.Open();
                SqlCommand comando = new SqlCommand(cmd, mi_conexion);
                comando.Parameters.AddWithValue("@descripcion_tipo_servicio", nombre);
                comando.Parameters.AddWithValue("@id", nombre);


                comando.ExecuteNonQuery();
                mi_conexion.Close();
                mostrarMensaje("Tipo de servicio actualizado correctamente");

               // limpiarForm();
            }
            else
            {
                //    mostrarMensaje("Por favor completar todos los campos");
            }
            llenar_datagrid();

        }

        //FUNCION LLENAR TEXBOX A MEDIDA QUE SELECCIONO EL DATAGRID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridView = dataGridView1.Rows[e.RowIndex];
            txt_descripcion1.Text = dataGridView.Cells[0].Value.ToString();
            //txt_area.Text = dataGridView.Cells[1].Value.ToString();
            //txt_registro.Text = dataGridView.Cells[7].Value.ToString();
            //txt_nombrecontacto.Text = dataGridView.Cells[2].Value.ToString();

        }

        //FUNCION ELIMINAR

        void eliminar()
        {

            if (validartextbox())
            {
                string nombre = txt_descripcion1.Text;
                string instruccion = "DELETE tipo_servicios WHERE descripcion_tipo_servicio like @nom";
                SqlCommand cmd = new SqlCommand(instruccion, mi_conexion);
                cmd.Parameters.AddWithValue("@nom", nombre);
                ejecutarQuery(mi_conexion, cmd);

                mostrarMensaje("Usuario eliminado correctamente");

                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
            }
            llenar_datagrid();
        }
        private void ejecutarQuery(SqlConnection conex, SqlCommand comando)
        {
            conex.Open();
            comando.ExecuteNonQuery();
            conex.Close();
        }
        private void limpiarForm()
        {
            foreach (Control variable in this.Controls)
            {
                if (variable is TextBox)
                {
                    (variable as TextBox).Clear();
                }
            }
        }

    }
}


