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
        string cadenaConnex = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        SqlConnection cn;

        // *********************** FORMULARIO ************************************
        public CONTACTOS()
        {
            InitializeComponent();
        }

        private void CONTACTOS_Load(object sender, EventArgs e)
        {

            cn = new SqlConnection(cadenaConnex);

        }


        // *********************** SELECTOR ************************************
        private void rbn_Crear_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Visible = true;
            txt_Id_Provincia.Visible = false;
            txt_Domicilio.Visible = true;
            txt_Telefono.Visible = true;
            txt_Mail.Enabled = true;
            cbx_Nombre.Visible = false;
            cbx_Id_Provincia.Visible = true;

            CargarProvincia_cbx();
            Llenar_datagrid();

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
            Llenar_datagrid();
        }

        private void rbn_Actualizar_CheckedChanged(object sender, EventArgs e)
        {
            txt_Nombre.Visible = false;
            txt_Domicilio.Visible = true;
            txt_Id_Provincia.Visible = false;
            txt_Telefono.Visible = true;
            cbx_Nombre.Visible = true;
            cbx_Id_Provincia.Visible = true;
            txt_Mail.Enabled = true;
            txt_Domicilio.Enabled = true;
            txt_Id_Provincia.Enabled = false;
            txt_Telefono.Enabled = true;
            txt_Mail.Enabled = true;
            CargarNombre_cbx();
            CargarProvincia_cbx();
            Llenar_datagrid();  
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
            CargarNombre_cbx();
            Llenar_datagrid();

        }


        // ************************************ BOTONES ******************************************
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

                    Llenar_datagrid();
                }
            }
            //listo
            if (rbn_Leer.Checked)
            {
                Limpiar();
                if (txt_Nombre.Text == "" || txt_Domicilio.Text == "" || txt_Telefono.Text == "" || txt_Mail.Text == "")
                {
                    MessageBox.Show("Por favor completar todos los campos");
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

                    Llenar_datagrid();
                }

            }
            //falta este
            if (rbn_Actualizar.Checked)
            {

                if (txt_Domicilio.Text == "" || txt_Telefono.Text == "" || txt_Mail.Text == "")
                {
                    MessageBox.Show("Por favor completar todos los campos");
                }
                else
                {
                    string nombre = cbx_Nombre.SelectedValue.ToString();
                    string domicilio = txt_Domicilio.Text;
                    string provincia = cbx_Id_Provincia.SelectedValue.ToString();
                    string telefono = txt_Telefono.Text;
                    string mail = txt_Mail.Text;


                    string cmd = "UPDATE contactos SET domicilio=@dom, Id_provincia=@prov, telefono=@tel, mail=@mail" +
                        " where id_contacto=@nom";

                    SqlCommand comando = new SqlCommand(cmd, cn);

                    comando.Parameters.AddWithValue("@nom", nombre);
                    comando.Parameters.AddWithValue("@dom", domicilio);
                    comando.Parameters.AddWithValue("@prov", provincia);
                    comando.Parameters.AddWithValue("@tel", telefono);
                    comando.Parameters.AddWithValue("@mail", mail);

                    cn.Open();
                    comando.ExecuteNonQuery();
                    cn.Close();
                    MessageBox.Show("Actualizo el registro.");
                    Limpiar();
                    Llenar_datagrid();

                }

            }
            //listo
            if (rbn_Borrar.Checked)
            {
                string nombre = cbx_Nombre.Text;
                string cmd = "DELETE  FROM contactos WHERE nombre=@nom";

                SqlCommand comando = new SqlCommand(cmd, cn);

                comando.Parameters.AddWithValue("@nom", nombre);

                cn.Open();
                comando.ExecuteNonQuery();
                cn.Close();

                MessageBox.Show("se borro el registro correctamente");
                Llenar_datagrid();
                Limpiar();
            }
        }


        // *********************************** FUNCIONES ************************************************
        void Limpiar()
        {
            txt_Nombre.Text = "";
            txt_Domicilio.Text = "";
            txt_Id_Provincia.Text = "";
            txt_Telefono.Text = "";
            txt_Mail.Text = "";
        }
        void CargarNombre_cbx()
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
        void CargarProvincia_cbx()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();

            cn.Open();

            mostrar_tipo = new SqlDataAdapter("SELECT id_provincia,provincia FROM provincias", cn);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_Id_Provincia.DataSource = data;
            cbx_Id_Provincia.ValueMember = "id_provincia"; //VARIABLE VISIBLE
            cbx_Id_Provincia.DisplayMember = "provincia"; //VARIABLE DESPLEGADA

            cn.Close();
        }

        void mostrar_campos(string id)
        {
            SqlDataAdapter llenar_campos;
            DataTable datacampos = new DataTable();
            //Abro la conexion
            cn.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            llenar_campos = new SqlDataAdapter("SELECT C.DOMICILIO, P.PROVINCIA, C.TELEFONO, C.MAIL " +
                                               "FROM CONTACTOS AS C, PROVINCIAS AS P " +
                                               "WHERE C.ID_PROVINCIA = P.ID_PROVINCIA AND ID_CONTACTO='" + id + "'", cn);

            llenar_campos.SelectCommand.Parameters.AddWithValue("@ID", id);
            //RELLENA LA VARIABLE DEL COMBO BOX
            llenar_campos.Fill(datacampos);
            if (datacampos.Rows.Count > 0)
            {
                //MessageBox.Show(datacampos.Rows[0][1].ToString());

                txt_Domicilio.Text = Convert.ToString(datacampos.Rows[0][0]);                cbx_Id_Provincia.Text = Convert.ToString(datacampos.Rows[0][1]);                txt_Telefono.Text = Convert.ToString(datacampos.Rows[0][2]);
                txt_Mail.Text = Convert.ToString(datacampos.Rows[0][3]);
               
            }
            //Cierra la conexion
            cn.Close();
        }

        
        void Llenar_datagrid()
        {
            SqlDataAdapter da;
            DataTable dt = new DataTable();
            cn.Open();
            string query = "select id_contacto,nombre,domicilio,provincia,telefono,mail " +
                "from contactos as c,provincias as p where  p.id_provincia=c.id_provincia";
            
           
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
    
       
        //FUNCION LLENAR TEXBOX A MEDIDA QUE SELECCIONO EL DATAGRID
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow dataGridView = dataGridView1.Rows[e.RowIndex];
            txt_Nombre.Text = dataGridView.Cells[0].Value.ToString();
            txt_Domicilio.Text = dataGridView.Cells[1].Value.ToString();
            txt_Telefono.Text = dataGridView.Cells[2].Value.ToString();
            txt_Mail.Text = dataGridView.Cells[3].Value.ToString();

        }


        private void cbx_Nombre_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrar_campos(cbx_Nombre.SelectedValue.ToString());
        }
    }
}
