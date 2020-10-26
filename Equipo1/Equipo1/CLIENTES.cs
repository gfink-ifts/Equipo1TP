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
    public partial class CLIENTES : Form
    {

        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=DESKTOP-6NP4PUO\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIO *******************
        public CLIENTES()
        {
            InitializeComponent();
        }

        private void CLIENTES_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);
        }

        //BOTON: EJECUTAR
        private void btn_Ejecutar_Click_1(object sender, EventArgs e)
        {
            //CRUD: CREAR
            if (rbn_Crear.Checked)
            {
                cbx_cliente.Visible = false;
                alta_clientes();

            }
            //CRUD: LEER
            if (rbn_Leer.Checked)
            {
                mostrar_clientes();
                llenar_clientes();
            }
            //CRUD: UPDATE
            if (rbn_Crear.Checked)
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
            if (rbn_Crear.Checked)
            {
            }
        }


        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_nombre.Text = "";
            txt_area.Text = "";
            txt_idcontacto.Text = "";
            txt_registro.Text = "";
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //FUNCION MOSTRAR CLIENTES
        void mostrar_clientes()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT ID_CLIENTE, NOMBRE FROM CLIENTES", mi_conexion);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_cliente.DataSource = data;
            cbx_cliente.ValueMember = "ID_CLIENTE"; //VARIABLE VISIBLE
            cbx_cliente.DisplayMember = "NOMBRE"; //VARIABLE DESPLEGADA





            //CIERRA LA CONEXION
            mi_conexion.Close();
        }

        //FUNCION llenar CLIENTES
        void llenar_clientes()

        {
            string cliente = cbx_cliente.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string consulta = "select area, id_contacto, fecha_registro from clientes " +
                " where nombre like @cli ";
            da = new SqlDataAdapter(consulta, mi_conexion);
            da.SelectCommand.Parameters.AddWithValue("@cli", "%" + cliente + "%");
            da.Fill(dt);
            mi_conexion.Close();

            if (dt.Rows.Count > 0)
            {
                txt_area.Text = Convert.ToString(dt.Rows[0][0]);
                txt_idcontacto.Text = Convert.ToString(dt.Rows[0][1]);
                txt_registro.Text = Convert.ToString(dt.Rows[0][2]);
            }
            else
            {
                MessageBox.Show("No existe el producto ");
            }


        }

        //FUNCION llenar CLIENTES
        void alta_clientes()
        {
            if (validarTextBoxes())
            {
                string nombre, area, id_contacto,registro;
               
                
                nombre = txt_nombre.Text;
                area = txt_area.Text;
                id_contacto = txt_idcontacto.Text;
                registro = txt_registro.Text;

                string cmd = "insert into Clientes (nombre,area,id_contacto,fecha_registro) " +
                                "values ( @nombre, @area,@id_contacto , @fecha_registro )";

                SqlCommand comando = new SqlCommand(cmd, mi_conexion);

                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@id_contacto", id_contacto);
                comando.Parameters.AddWithValue("@fecha_registro", registro);

               // mi_conexion.Open();
                //comando.ExecuteNonQuery();
                //mi_conexion.Close();

                ejecutarQuery(mi_conexion, comando);
                mostrarMensaje("Usuario creado correctamente");

                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
            }
        }

        private bool validarTextBoxes()
        {
            bool respuesta = true;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    if ((c as TextBox).Text == "")
                    {
                        respuesta = false;
                    }
                }
            }
            return respuesta;

        }

        private void ejecutarQuery(SqlConnection conex, SqlCommand comando)
        {
            conex.Open();
            comando.ExecuteNonQuery();
            conex.Close();
        }

        private void mostrarMensaje(string mensaje)
        {
            MessageBox.Show(mensaje);
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
