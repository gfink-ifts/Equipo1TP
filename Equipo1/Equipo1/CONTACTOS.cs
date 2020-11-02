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
        //FUNCION ACTUALIZAR
        void actualizar()
        {
            if (verificartextbox())
            {
                string nombre = txt_Nombre.Text;
                string domicilio = txt_Domicilio.Text;
                string telefono = txt_Telefono.Text;
                string mail = txt_Mail.Text;


                string cmd = "update contactos set domicilio=@dom , telefono=@tel, mail@ail where nombre like @id";
                cn.Open();
                SqlCommand comando = new SqlCommand(cmd, cn);

                comando.Parameters.AddWithValue("@dom", domicilio);
                comando.Parameters.AddWithValue("@tel", telefono);
                comando.Parameters.AddWithValue("@mail", mail);
                comando.Parameters.AddWithValue("@id", nombre);
                /*
               string nombre = cbx_Nombre.SelectedValue.ToString();
               string domicilio = txt_Domicilio.Text;
               string id = cbx_Id_Provincia.SelectedValue.ToString();
               int telefono = Convert.ToInt32(txt_Telefono.Text);
               int mail = Convert.ToInt32(txt_Mail.Text);

               //VARIABLE DONDE ALMACENO LA INSTRUCCION
               //update Productos set id_tipo = 7    where descripcion like 'Yerba'
               SqlCommand actualizar_registro = new SqlCommand("UPDATE contactos SET nombre=@nom, domicilio=@dom,id=@id , telefono=@tel, mail=@mail" +
               "WHERE id_contactos=@id", cn);

               //VINCULACION DE PARAMETROS
               actualizar_registro.Parameters.AddWithValue("@nom", nombre);
               actualizar_registro.Parameters.AddWithValue("@dom", domicilio);
               actualizar_registro.Parameters.AddWithValue("@id", id);
               actualizar_registro.Parameters.AddWithValue("@tel", telefono);
               actualizar_registro.Parameters.AddWithValue("@mail", mail);

               cn.Open();
               //EJECUTO LA QUERY
               actualizar_registro.ExecuteNonQuery();*/
                cn.Close();
                MessageBox.Show("Actualizo el registro.");
                Limpiar();
                llenar_datagrid();

            }
        }
        void Limpiar()
        {
            txt_Nombre.Text = "";
            txt_Domicilio.Text = "";
            txt_Id_Provincia.Text = "";
            txt_Telefono.Text = "";
            txt_Mail.Text = "";
        }
        void cargarNombre_cbx()
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
        void cargarProvincia_cbx()
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
        void llenar_datagrid()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string query = "select nombre,domicilio,telefono,mail from contactos ";
            
           
            da = new SqlDataAdapter(query, cn);
            da.Fill(dt);
            cn.Close();
            dataGridView1.DataSource = dt;
        }
        private void ejecutarQuery(SqlConnection conex, SqlCommand comando)
        {
            conex.Open();
            comando.ExecuteNonQuery();
            conex.Close();
        }
        void eliminar()

        { 
            if (verificartextbox())
            {
                string nombre = txt_Nombre.Text;
                string domicilio = txt_Domicilio.Text;
                string telefono = txt_Telefono.Text;
                string mail = txt_Mail.Text;
                string instruccion = "DELETE clientes WHERE nombre,domicilio,telefono,mail like @nom,@dom,@tel,@mail";
                SqlCommand cmd = new SqlCommand(instruccion, cn);
                cmd.Parameters.AddWithValue("@nom", nombre);
                cmd.Parameters.AddWithValue("@dom", domicilio);
                cmd.Parameters.AddWithValue("@tel", telefono);
                cmd.Parameters.AddWithValue("@mail", mail);
                ejecutarQuery(cn, cmd);
                MessageBox.Show ("Usuario eliminado correctamente");
                Limpiar();
            }
            else
            {
                MessageBox.Show ("Por favor completar todos los campos");
            }
        }
        //FUNCION Verifica TEXBOX
        private bool verificartextbox()
            {
                bool respuesta = true;
                if (txt_Nombre.Text == "" || txt_Domicilio.Text == "" || txt_Telefono.Text == "" || txt_Mail.Text == "")
                {
                    respuesta = false;
                }
			    else
                {
                MessageBox.Show ("Por favor completar todos los campos");
                }
                return respuesta;
            }
        
        //FUNCION LLENAR TEXBOX A MEDIDA QUE SELECCIONO EL DATAGRID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridView = dataGridView1.Rows[e.RowIndex];
            txt_Nombre.Text = dataGridView.Cells[0].Value.ToString();
            txt_Domicilio.Text = dataGridView.Cells[1].Value.ToString();
            txt_Telefono.Text = dataGridView.Cells[2].Value.ToString();
            txt_Mail.Text = dataGridView.Cells[3].Value.ToString();

        }
        //botones
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            //listo
            if (rbn_Crear.Checked)
            {
                if (txt_Nombre.Text == "" || txt_Domicilio.Text == "" || txt_Telefono.Text == "" || txt_Mail.Text == "")
                {
                    MessageBox.Show("Por favor completar todos los campos");
                }
                else
                {

                    string nombre = txt_Nombre.Text;
                    string domicilio = txt_Domicilio.Text;
                    string id = cbx_Id_Provincia.SelectedValue.ToString();
                    int telefono = Convert.ToInt32(txt_Telefono.Text);
                    string mail = txt_Mail.Text;

                    string cmd = "insert into CONTACTOS  (nombre,domicilio,id_provincia,telefono,mail) "
                        + "values (@nom, @dom,@id, @tel, @mail)";


                    //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@dom", domicilio);
                    comando.Parameters.AddWithValue("@id", id);
                    comando.Parameters.AddWithValue("@tel", telefono);
                    comando.Parameters.AddWithValue("@mail", mail);

                    cn.Open();

                    comando.ExecuteNonQuery();

                    cn.Close();

                    MessageBox.Show("contacto creado correctamente");
                    llenar_datagrid();
                }
            }
            //listo
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
                Limpiar();
                llenar_datagrid();
            }
            if (rbn_Actualizar.Checked)
            {
                actualizar();
                
                //listo
               

            }
            if (rbn_Borrar.Checked)
            {
                eliminar();
                ///DECLARACION DE VARIABLES
                string id = cbx_Nombre.SelectedValue.ToString();
                //CREACION DE LA VARIABLE: BORRAR
                SqlCommand borrar = new SqlCommand();

                //VARIABLE + CONEXION
                borrar = cn.CreateCommand();


                borrar.CommandText = "DELETE FROM contactos WHERE id_contacto=@ID";

                //VINCULACION DE PARAMETROS
                borrar.Parameters.AddWithValue("@ID", id);
                cn.Open();
                //EJECUTO LA INSTRUCION SQL
                borrar.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("se borro el registro correctamente");
                llenar_datagrid();
            }
        }
        private void cbx_Nombre_SelectedIndexChanged(object sender, EventArgs e)
        {
        
		}
        //carga los cbx segun combo box
        private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Visible = true;
            txt_Id_Provincia.Visible = false;
            txt_Domicilio.Visible = true;
            txt_Telefono.Visible = true;
            txt_Mail.Enabled = true;
            cbx_Nombre.Visible = false;
            cbx_Id_Provincia.Visible = true;
            cargarProvincia_cbx();
            llenar_datagrid();

        }

        private void rbn_Leer_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Enabled = false;
            txt_Id_Provincia.Enabled = false;
            txt_Domicilio.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Mail.Enabled = false;
            txt_Nombre.Visible = true;
            txt_Domicilio.Visible = true;
            txt_Id_Provincia.Visible = true;
            txt_Telefono.Visible = true;
            txt_Mail.Visible = true;
            cbx_Nombre.Visible = false;
            cbx_Id_Provincia.Visible = false;
            llenar_datagrid();
        }

        private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Visible = true;
            txt_Domicilio.Visible = true;
            txt_Id_Provincia.Visible =true;
            txt_Telefono.Visible = true;
            txt_Mail.Enabled = true;
            cbx_Nombre.Visible = true;
            txt_Domicilio.Enabled = true;
            cbx_Id_Provincia.Visible =false;
            txt_Id_Provincia.Enabled  =false;
            txt_Telefono.Enabled  = true;
            txt_Mail.Enabled  = true;
            cargarNombre_cbx();
            cargarProvincia_cbx();
            llenar_datagrid();
        }

        private void rbn_Borrar_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Enabled = false;
            txt_Id_Provincia.Enabled = false;
            txt_Domicilio.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Mail.Enabled = false;
            txt_Nombre.Visible = false;
            txt_Id_Provincia.Visible = true;
            txt_Domicilio.Visible = true;
            txt_Telefono.Visible = true;
            txt_Mail.Visible = true;
            cbx_Nombre.Visible = true;
            cbx_Id_Provincia.Visible = false;
            cargarNombre_cbx();
            llenar_datagrid();

        }

    }
}
