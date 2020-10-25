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
    public partial class VENTAS : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIO *******************
        public VENTAS()
        {
            InitializeComponent();
        }

        private void VENTAS_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);
        }


        //  ******************* SELECTOR *******************
        //SELECTOR: CREAR
        private void rbn_crear_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();
            Limpiar();
        }

        //SELECTOR: LEER
        private void rbn_leer_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
        }

        //SELECTOR: ACTUALIZAR
        private void rbn_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            Limpiar();
        }

        //SELECTOR: BORRAR
        private void rbn_borrar_CheckedChanged(object sender, EventArgs e)
        {
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
            //CRUD: ACTUALIZAR
            else if (rbn_actualizar.Checked)
            {

            }
            //CRUD: BORRAR
            else if (rbn_borrar.Checked)
            {

            }
            //MENSAJE DE ERROR 
            else
            {
                MessageBox.Show("Seleccione una de las \nopciones de arriba");
            }
        }

        //BOTON: SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbx_cliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // mostrar_campos(cbx_cliente.SelectedValue.ToString());
        }

        private void cbx_servicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //mostrar_campos(cbx_servicio.SelectedValue.ToString());
        }


        //  ******************* FUNCIONES *******************
        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_cantidad.Text = "";
            txt_fecha.Text = "";
            txt_orden.Text = "";
            cbx_cliente.Text = "";
            cbx_servicio.Text = "";
        }

        //FUNCION MOSTRAR SERVICIOS
        void mostrar_servicios()
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
            cbx_servicio.DataSource = data;
            cbx_servicio.ValueMember = "id_servicios"; //VARIABLE VISIBLE
            cbx_servicio.DisplayMember = "descripcion"; //VARIABLE DESPLEGADA
            //CIERRA LA CONEXION
            mi_conexion.Close();
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

        /*
        //FUNCION LLENA LOS CAMPOS
        void mostrar_campos(string id)
        {
            SqlDataAdapter llenar_campos;
            DataTable datacampos = new DataTable();
            //Abro la conexion
            mi_conexion.Open();
            //VARIABLE DONDE ALMACENO LA INSTRUCCION
            llenar_campos = new SqlDataAdapter("SELECT V.FECHA_VENTA, S.DESCRIPCION, V.ORDEN_DE_COMPRA, V.CANTIDAD " +
                                               "FROM VENTAS AS V, SERVICIOS AS S " +
                                               "WHERE V.ID_CLIENTE = S.ID_SERVICIOS AND ID_VENTAS=@ID", mi_conexion);
            llenar_campos.SelectCommand.Parameters.AddWithValue("@ID", id);
            //RELLENA LA VARIABLE DEL COMBO BOX
            llenar_campos.Fill(datacampos);
            if (datacampos.Rows.Count > 0)
            {
                txt_fecha.Text = Convert.ToString(datacampos.Rows[0][0]);
                cbx_servicio.SelectedIndex = (Convert.ToInt32(datacampos.Rows[0][1]) - 1);
                txt_orden.Text = Convert.ToString(datacampos.Rows[0][2]);
                txt_cantidad.Text = Convert.ToString(datacampos.Rows[0][3]);
            }
            //Cierra la conexion
            mi_conexion.Close();
        }
        */
    }
}
