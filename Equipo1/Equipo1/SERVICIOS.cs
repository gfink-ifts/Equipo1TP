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

            Limpiar();
        }

        //SELECTOR: LEER
        private void rbn_leer_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;

            mostrar_servicios();
            Limpiar();
        }

        //SELECTOR: ACTUALIZAR
        private void rbn_actualizar_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;

            mostrar_servicios();
            Limpiar();
            
        }

        //SELECTOR: BORRAR
        private void rbn_borrar_MouseClick(object sender, MouseEventArgs e)
        {
            //ENCIENDE Y APAGA LOS CONTROLES
            cbx_descripcion.Visible = true;
            txt_descripcion.Visible = false;

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
                
            }
            //CRUD: UPDATE
            else if (rbn_actualizar.Checked)
            {
                string precio = Convert.ToString(txt_precio.Text);
                int index = (cbx_descripcion.SelectedIndex);
                string id = (index + 1).ToString();
                MessageBox.Show(id);

                //VARIABLE DONDE ALMACENO LA INSTRUCCION
                SqlCommand actualizar_registro = new SqlCommand ("UPDATE SERVICIOS SET PRECIOS=@precio WHERE id_servicios=@id", mi_conexion);

                //VINCULACION DE PARAMETROS
                actualizar_registro.Parameters.AddWithValue("@precio", precio);
                actualizar_registro.Parameters.AddWithValue("@id", id);

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

        //FUNCION LLENA LOS CAMPOS
        void mostrar_campos(string id)
        {
            SqlDataAdapter llenar_campos;
            DataTable datacampos = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            llenar_campos = new SqlDataAdapter("SELECT S.precios, T.descripcion FROM SERVICIOS AS S, TIPO_SERVICIOS AS T where S.id_tipo_servicios = T.id_tipo_servicios and s.id_servicios=@ID", mi_conexion);
            llenar_campos.SelectCommand.Parameters.AddWithValue("@ID", id);
            //RELLENA LA VARIABLE DEL COMBO BOX
            llenar_campos.Fill(datacampos);
            if (datacampos.Rows.Count > 0)
            {
                txt_precio.Text = Convert.ToString(datacampos.Rows[0][0]);
                txt_tipo.Text = Convert.ToString(datacampos.Rows[0][1]);
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

        private void cbx_descripcion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            mostrar_campos(cbx_descripcion.SelectedValue.ToString());
        }


    }
}
