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
        string conectar = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
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

            {
                //CRUD: CREAR
                if (rbn_Crear.Checked)
                {
                    alta_clientes();
                    Limpiar();

                }


                //CRUD: LEER
              //  if (rbn_Leer.Checked)
                //{
                   //txt_nombrecontacto.Visible = true;
                    
               // }

                //CRUD: UPDATE
                if (rbn_Actualizar.Checked)
                {
                  // cbx_cliente.Visible = false; 
                    actualizar();
                   llenar_datagrid();
                }

                //CRUD: DELETE
                if (rbn_Borrar.Checked)
                {                    
                    eliminar();                   
                }
            }
        }
        //BOTON BUSCAR POR CLIENTE
        private void btn_buscarcliente_Click(object sender, EventArgs e)
        {
            /*string apellido = txt_cliente.Text;*/
            string nombre = txt_buscarcliente.Text;
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            mi_conexion.Open();
            string consulta ="select c.nombre,c.area,co.nombre,co.domicilio,p.provincia,co.telefono, co.mail,c.fecha_registro from clientes as c, contactos as co ,provincias as p where c.id_contacto = co.id_contacto and co.id_provincia = p.id_provincia  and c.nombre like @nombre"; 
            da = new SqlDataAdapter(consulta, mi_conexion);
            /*da.SelectCommand.Parameters.AddWithValue("@apell", "%" + apellido + "%" );*/
            da.SelectCommand.Parameters.AddWithValue("@nombre", "%" + nombre + "%");
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mi_conexion.Close();
        }
        //BOTON PARA MOSTRAR TODOS LOS DATOS DE LOS CLIENTES
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
        private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
        {
            limpiarForm();
            
            cbx_nombrecontacto.Visible = true;
            btn_buscarcliente.Visible = false;
            txt_nombre.Enabled = true;
            txt_area.Enabled = true;
            txt_registro.Enabled = true;
            cbx_cliente.Visible = false;
            btn_Ejecutar.Visible = true;
            txt_nombrecontacto.Visible = false;
            txt_buscarcliente.Visible = false;
            mostrar_contactos();
            llenar_datagrid();
            
        }
        private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
        {
            cbx_nombrecontacto.Visible = false;
            btn_Ejecutar.Visible = false;
            cbx_cliente.Visible = false;
            btn_buscarcliente.Visible = true;
            txt_nombrecontacto.Visible = true;
            txt_buscarcliente.Visible = true;
            txt_area.Enabled = false;
            txt_registro.Enabled = false;
            txt_nombre.Enabled = false;
            txt_nombrecontacto.Enabled = false;
            mostrar_clientes();
            mostrar_contactos();
            llenar_clientes();
            llenar_datagrid();
           
        }
        private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            limpiarForm();
            cbx_nombrecontacto.Visible = false;
            btn_buscarcliente.Visible = true;
            btn_Ejecutar.Visible = true;
            cbx_cliente.Visible = false;
            cbx_nombrecontacto.Visible = true;
            txt_nombre.Enabled = true;
            txt_area.Enabled = true;
            txt_registro.Enabled = true;
            txt_nombrecontacto.Visible = true;
            txt_nombrecontacto.Enabled = false;
            mostrar_contactos();
            mostrar_clientes();
            llenar_datagrid();
        }
        private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
        {
            limpiarForm();
            cbx_nombrecontacto.Visible = false;
            btn_buscarcliente.Visible = true;
            txt_nombre.Enabled = true;
            txt_area.Enabled = true;
            txt_registro.Enabled = true;
            cbx_cliente.Visible = false;
            txt_nombrecontacto.Visible = true;
            txt_nombrecontacto.Enabled = false;

            llenar_datagrid();
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
        //FUNCION MOSTRAR CONTACTOS EN COMBOX
        void mostrar_contactos()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT ID_contacto, NOMBRE FROM contactos", mi_conexion);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_nombrecontacto.DataSource = data;
            cbx_nombrecontacto.ValueMember = "ID_CONTACTO"; //VARIABLE VISIBLE
            cbx_nombrecontacto.DisplayMember = "NOMBRE"; //VARIABLE DESPLEGADA





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
            string consulta = "select c.area, co.nombre, c.fecha_registro from clientes as c, contactos as co " +
                     " where c.id_contacto=co.id_contacto and co.nombre=@nom ";
            da = new SqlDataAdapter(consulta, mi_conexion);
            da.SelectCommand.Parameters.AddWithValue("@nom", "%" + cliente + "%");
            da.Fill(dt);
            mi_conexion.Close();

            if (dt.Rows.Count > 0)
            {
                txt_area.Text = Convert.ToString(dt.Rows[0][0]);
                txt_nombrecontacto.Text = Convert.ToString(dt.Rows[0][1]);
                txt_registro.Text = Convert.ToString(dt.Rows[0][2]);
            }
           // else
            //{
              //  MessageBox.Show("No existe Cliente ");
            //}


        }

        //FUNCION Alta CLIENTES
        void alta_clientes()
        {
            if (validartextbox())
            {
                string nombre, area, id, registro;
                mi_conexion.Open();
                nombre = txt_nombre.Text;
                id = cbx_nombrecontacto.SelectedValue.ToString();
                area = txt_area.Text;
                registro = txt_registro.Text;

                string cmd = "insert into Clientes (nombre,area,id_contacto,fecha_registro) " +                             "values ( @nombre, @area ,@id, @fecha_registro )";



                SqlCommand comando = new SqlCommand(cmd, mi_conexion);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@fecha_registro", registro);

                
                comando.ExecuteNonQuery();
                mi_conexion.Close();
                mostrarMensaje("Cliente dado de alta correctamente");

                
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
            llenar_datagrid();
        }

        //FUNCION LLENAR DATAGRID
        void llenar_datagrid()
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
            txt_registro.Text = dataGridView.Cells[7].Value.ToString();
            txt_nombrecontacto.Text = dataGridView.Cells[2].Value.ToString();

        }
          //FUNCION ACTUALIZAR
          void actualizar()
          {
            if (validartextbox())
            {
                  string nombre = txt_nombre.Text;
                string id = cbx_nombrecontacto.SelectedValue.ToString();
                  string area=txt_area.Text;
              

            string cmd = "update Clientes set area=@area, id_contacto=@id where nombre=@nombre";
            mi_conexion.Open();
            SqlCommand comando = new SqlCommand(cmd, mi_conexion);
             comando.Parameters.AddWithValue("@area", area);
                comando.Parameters.AddWithValue("@id", id);
                comando.Parameters.AddWithValue("@nombre", nombre );

            
                  comando.ExecuteNonQuery();
                  mi_conexion.Close();
                  mostrarMensaje("Usuario actualizado correctamente");

                  limpiarForm();
              }
              else
              {
              //    mostrarMensaje("Por favor completar todos los campos");
             }
              llenar_datagrid();

          }

       
    }
}
