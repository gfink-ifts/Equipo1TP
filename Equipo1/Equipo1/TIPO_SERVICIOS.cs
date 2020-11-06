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
        string conectar = @"data source=DESKTOP-6NP4PUO\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
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
        }

        //BOTON: EJECUTAR
        private void btn_ejecutar_Click_1(object sender, EventArgs e)
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
            }
        }


      

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
            cbx_descripcion.Visible = false;
            
        }

        private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
        }
        private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
        }

        private void rbn_Eliminar_CheckedChanged(object sender, EventArgs e)
        {
            llenar_datagrid();
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
            string query = "select t.descripcion,s.descripcion,s.precios from tipo_servicios as t, servicios as s where t.id_tipo_servicios = s.id_tipo_servicios ";

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

                string cmd = "insert into tipo_servicios (descripcion) " +
                                "values ( @descripcion)";


                SqlCommand comando = new SqlCommand(cmd, mi_conexion);
                comando.Parameters.AddWithValue("@descripcion", descripcion);
               // comando.Parameters.AddWithValue("@area", area);
                //comando.Parameters.AddWithValue("@fecha_registro", registro);


                comando.ExecuteNonQuery();
                mi_conexion.Close();
                mostrarMensaje("Tipo de Servicio dado de alta correctamente");


            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
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

       
    }
}


