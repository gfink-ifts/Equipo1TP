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
            llenar_datagrid();

            {
                //CRUD: CREAR
                if (rbn_Crear.Checked)
                {
                    cbx_cliente.Visible = false;
                    txt_nombrecontacto.Visible = false;
                    alta_clientes();
                    
                    Limpiar();

                }


                //CRUD: LEER
                if (rbn_Leer.Checked)
                {
                    mostrar_clientes();
                    llenar_clientes();
                    llenar_datagrid();
                }

                //CRUD: UPDATE
                if (rbn_Actualizar.Checked)
                {
                    cbx_cliente.Visible = false;
                    txt_nombrecontacto.Visible = false;
                    llenar_datagrid();



                }

                //CRUD: DELETE
                if (rbn_Borrar.Checked)
                {
                    cbx_cliente.Visible = false;
                    txt_nombrecontacto.Visible = false;
                    eliminar();
                    llenar_datagrid();

                }


                //VERIFICAR CHECKED

                if (rbn_Crear.Checked == false || rbn_Leer.Checked == false || rbn_Actualizar.Checked == false || rbn_Borrar.Checked == false)
                {
                    MessageBox.Show("Elija/Chequee una de las opciones: Crear, Leer, Actualizar o Borrar ");
                }





            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string query = "select c.nombre,c.area,co.nombre,co.domicilio,p.provincia,co.telefono, co.mail,c.fecha_registro from clientes as c, contactos as co ,provincias as p where c.id_contacto = co.id_contacto and co.id_provincia = p.id_provincia ";

            da = new SqlDataAdapter(query, mi_conexion);

            da.Fill(dt);

            mi_conexion.Close();

            dataGridView1.DataSource = dt;
        }
        //FUNCIONES
        //**********************************************************************************************************

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_nombre.Text = "";
            txt_area.Text = "";
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
                txt_nombrecontacto.Text = Convert.ToString(dt.Rows[0][1]);
                txt_registro.Text = Convert.ToString(dt.Rows[0][2]);
            }
            else
            {
                MessageBox.Show("No existe el producto ");
            }


        }

        //FUNCION Alta CLIENTES
        void alta_clientes()
        {
            if (validartextbox())
            {
                string nombre, area, registro;

                nombre = txt_nombre.Text;
                area = txt_area.Text;
                registro = txt_registro.Text;

                string cmd = "insert into Clientes (nombre,area,fecha_registro) " +
                                "values ( @nombre, @area , @fecha_registro )";
               

                SqlCommand comando = new SqlCommand(cmd, mi_conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@fecha_registro", registro);

                mostrarMensaje("Usuario creado correctamente");

                limpiarForm();
            }
            else
            {
                mostrarMensaje("Por favor completar todos los campos");
            }
            llenar_datagrid();

        }

        //FUNCION VALIDAS TEXBOX
        private bool validartextbox()
        {
            bool respuesta = true;


            if (txt_nombre.Text == "" || txt_area.Text == "" || txt_registro.Text == "")
            {
                respuesta = false;
            }
            else
            {
                
            }


            return respuesta;
        }

        //FUNCION VALIDAS TEXBOX
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

        private void cbx_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrar_campos(cbx_cliente.SelectedValue.ToString());
        }

        //FUNCION LLENA LOS CAMPOS
        void mostrar_campos(string id)
        {
            SqlDataAdapter llenar_campos;
            DataTable datacampos = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            llenar_campos = new SqlDataAdapter("SELECT c.area, co.nombre, c.fecha_registro " + "FROM clientes AS c, contactos AS co " +
                                               "WHERE c.ID_contacto = co.ID_contacto AND ID_cliente=@ID", mi_conexion);
            llenar_campos.SelectCommand.Parameters.AddWithValue("@ID", id);
            //RELLENA LA VARIABLE DEL COMBO BOX
            llenar_campos.Fill(datacampos);
            if (datacampos.Rows.Count > 0)
            {
                txt_area.Text = Convert.ToString(datacampos.Rows[0][0]);
                txt_nombrecontacto.Text = Convert.ToString(datacampos.Rows[0][1]);
                txt_registro.Text = Convert.ToString(datacampos.Rows[0][2]);

            }
            //Cierra la conexion
            mi_conexion.Close();
        }

        //FUNCION LLENAR DATAGRID
        void llenar_datagrid()
        {

            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string query = "select nombre, area, fecha_registro from clientes" ;
                     
            da = new SqlDataAdapter(query, mi_conexion);

            da.Fill(dt);

            mi_conexion.Close();

            dataGridView1.DataSource = dt;

        }

             

        //FUNCION ELIMINAR

        void eliminar()
        {
            
            if (validartextbox())
            {
                string nombre = txt_nombre.Text;
                string instruccion = "DELETE clientes WHERE nombre like @nom";
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

//FUNCION LLENAR TEXBOX A MEDIDA QUE SELECCIONO EL DATAGRID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridView = dataGridView1.Rows[e.RowIndex];
            txt_nombre.Text = dataGridView.Cells[0].Value.ToString();
            txt_area.Text = dataGridView.Cells[1].Value.ToString();
            txt_registro.Text = dataGridView.Cells[2].Value.ToString();
        }
    }
}
