using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//LIBRERIA SQL
using System.Data.Sql;
using System.Data.SqlClient;

namespace Equipo1
{
    public partial class SERVICIOS : Form
    {

        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIO *******************
        public SERVICIOS()
        {
            InitializeComponent();
        }

        private void SERVICIOS_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);
        }

        //  ******************* SELECTOR *******************

        //SELECTOR: CREAR
        private void rbn_crear_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = false;
            txt_descripcion.Visible = true;
            cbx_tipo.Visible = false;
            txt_tipo.Visible = true;

            Limpiar();
        }

        //SELECTOR: LEER
        private void rbn_leer_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;
            cbx_tipo.Visible = false;
            txt_tipo.Visible = true;

            mostrar_servicios();
            Limpiar();
        }

        //SELECTOR: ACTUALIZAR
        private void rbn_actualizar_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;
            cbx_tipo.Visible = true;
            txt_tipo.Visible = false;

            mostrar_servicios();
            mostrar_tipo();
            Limpiar();
            
        }

        //SELECTOR: BORRAR
        private void rbn_borrar_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;
            cbx_tipo.Visible = false;
            txt_tipo.Visible = true;

            mostrar_servicios();
            Limpiar();

        }


        //  ******************* BOTONES *******************

        //BOTON: EJECUTAR
        private void btn_ejecutar_Click(object sender, EventArgs e)
        {

            //CRUD: CREAR
            if (rbn_crear.Checked)
            {
                
            }
            //CRUD: LEER
            else if (rbn_leer.Checked)
            {
                int index = cbx_descripcion.SelectedIndex;
                string id = (index + 1).ToString();

                SqlDataAdapter leer_registro;
                DataTable data = new DataTable();

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                leer_registro = new SqlDataAdapter("SELECT * WHERE id_servicios=@id", mi_conexion);

                //VINCULACION DE PARAMETROS
                //leer_registro.Parameters.AddWithValue("@id", id);

                //ABRO LA CONEXION
                mi_conexion.Open();

                //EJECUTO LA QUERY
                //actualizar_registro.ExecuteNonQuery();

                //CIERRO LA CONEXION
                mi_conexion.Close();

                MessageBox.Show("Actualizo el registro.");

                Limpiar();
            }
            //CRUD: UPDATE
            else if (rbn_actualizar.Checked)
            {
                string precio = Convert.ToString(txt_precio.Text);
                int index = cbx_descripcion.SelectedIndex;
                string id = (index + 1).ToString();
                int index_tipo = cbx_tipo.SelectedIndex;
                string id_tipo = (index_tipo + 1).ToString();
                
                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                SqlCommand actualizar_registro = new SqlCommand ("UPDATE SERVICIOS SET PRECIOS=@precio, ID_TIPO_SERVICIOS=@id_tipo WHERE id_servicios=@id", mi_conexion);

                //VINCULACION DE PARAMETROS
                actualizar_registro.Parameters.AddWithValue("@precio", precio);
                actualizar_registro.Parameters.AddWithValue("@id", id);
                actualizar_registro.Parameters.AddWithValue("@id_tipo", id_tipo);

                //ABRO LA CONEXION
                mi_conexion.Open();

                //EJECUTO LA QUERY
                actualizar_registro.ExecuteNonQuery();

                //CIERRO LA CONEXION
                mi_conexion.Close();

                MessageBox.Show("Actualizo el registro.");

                Limpiar();
            }
            //CRUD: DELETE
            else if (rbn_borrar.Checked)
            {
                
            }
            else
            {
                MessageBox.Show("Seleccione una de las \nopciones de arriba");
            }
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_descripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrar_campos(cbx_descripcion.SelectedValue.ToString());
        }

        //  ******************* FUNCIONES *******************

        //FUNCION MOSTRAR SERVICIOS
        void mostrar_servicios ()
        {
            SqlDataAdapter mostrar_servicios;
            DataTable data = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_servicios = new SqlDataAdapter("select id_servicios, descripcion from SERVICIOS", mi_conexion);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_servicios.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_descripcion.DataSource = data;
            cbx_descripcion.ValueMember = "id_servicios"; //VARIABLE VISIBLE
            cbx_descripcion.DisplayMember = "descripcion"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            mi_conexion.Close();
        }

        //FUNCION MOSTRAR TIPO
        void mostrar_tipo()
        {
            SqlDataAdapter mostrar_tipo;
            DataTable data = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            mostrar_tipo = new SqlDataAdapter("SELECT ID_TIPO_SERVICIOS, DESCRIPCION FROM TIPO_SERVICIOS", mi_conexion);
            //RELLENA LA VARIABLE DEL COMBO BOX
            mostrar_tipo.Fill(data);
            //RELLENA EL COMBO BOX
            cbx_tipo.DataSource = data;
            cbx_tipo.ValueMember = "ID_TIPO_SERVICIOS"; //VARIABLE VISIBLE
            cbx_tipo.DisplayMember = "DESCRIPCION"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            mi_conexion.Close();
        }

        //FUNCION LLENA LOS CAMPOS
        void mostrar_campos(string id)
        {
            SqlDataAdapter llenar_campos;
            DataTable datacampos = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            llenar_campos = new SqlDataAdapter("SELECT S.precios, T.descripcion, T.ID_TIPO_SERVICIOS FROM SERVICIOS AS S, TIPO_SERVICIOS AS T where S.id_tipo_servicios = T.id_tipo_servicios and s.id_servicios=@ID", mi_conexion);
            llenar_campos.SelectCommand.Parameters.AddWithValue("@ID", id);
            //RELLENA LA VARIABLE DEL COMBO BOX
            llenar_campos.Fill(datacampos);
            if (datacampos.Rows.Count > 0)
            {
                txt_precio.Text = Convert.ToString(datacampos.Rows[0][0]);
                txt_tipo.Text = Convert.ToString(datacampos.Rows[0][1]);
                cbx_tipo.SelectedIndex = (Convert.ToInt32(datacampos.Rows[0][2]))-1;
            }
            //Cierra la conexion
            mi_conexion.Close();
        }

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_descripcion.Text = "";
            txt_precio.Text = "";
            txt_tipo.Text = "";
        }

        
    }
}
