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

            lbl_error_cliente.Visible = false;
            lbl_error_fecha.Visible = false;
            lbl_error_servicio.Visible = false;
            rbn_borrar.Enabled = false;
            rbn_actualizar.Enabled = false;

        }


        //  ******************* SELECTOR *******************
        //SELECTOR: CREAR
        private void rbn_crear_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();

            //ENABLE CAMPOS
            lbl_oc.Enabled = true;
            txt_oc.Enabled = true;
            lbl_cantidad.Enabled = true;
            txt_cantidad.Enabled = true;
            chx_cliente.Enabled = false;
            chx_fecha.Enabled = false;
            chx_servicios.Enabled = false;

            Limpiar();
        }

        //SELECTOR: LEER
        private void rbn_leer_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();

            //ENABLE CAMPOS
            lbl_oc.Enabled = false;
            txt_oc.Enabled = false;
            lbl_cantidad.Enabled = false;
            txt_cantidad.Enabled = false;
            chx_cliente.Enabled = true;
            chx_fecha.Enabled = true;
            chx_servicios.Enabled = true;

            Limpiar();
        }

        //SELECTOR: ACTUALIZAR
        private void rbn_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();
            Limpiar();
        }

        //  ******************* BOTONES *******************
        //BOTON: EJECUTAR
        private void btn_ejecutar_Click(object sender, EventArgs e)
        {

            string fecha = Convert.ToString(txt_fecha.Text);
            string id_cliente = cbx_cliente.SelectedValue.ToString();
            string id_servicio = cbx_servicio.SelectedValue.ToString();
            string consulta = "";
            string orden_compra = Convert.ToString(txt_oc.Text);
            string cantidad = Convert.ToString(txt_cantidad.Text);

            //CRUD: CREAR
            if (rbn_crear.Checked)
            {
                //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
                SqlCommand nuevo_registro = new SqlCommand();

                //MATCHEO VARIABLE A LA CONEXION
                nuevo_registro = mi_conexion.CreateCommand();

                //INSTRUCCION SQL
                nuevo_registro.CommandText = "INSERT INTO VENTAS (FECHA_VENTA, ID_CLIENTE, ID_SERVICIOS, ORDEN_DE_COMPRA, CANTIDAD)" +
                                             "VALUES (@FECHA_VENTA, @ID_CLIENTE, @ID_SERVICIOS, @ORDEN_DE_COMPRA, @CANTIDAD)";

                //VINCULACION DE PARAMETROS
                nuevo_registro.Parameters.AddWithValue("@FECHA_VENTA", fecha);
                nuevo_registro.Parameters.AddWithValue("@ID_CLIENTE", id_cliente);
                nuevo_registro.Parameters.AddWithValue("@ID_SERVICIOS", id_servicio);
                nuevo_registro.Parameters.AddWithValue("@ORDEN_DE_COMPRA", orden_compra);
                nuevo_registro.Parameters.AddWithValue("@CANTIDAD", cantidad);


                //ABRO LA CONEXION
                mi_conexion.Open();

                //EJECUTO LA INSTRUCCION SQL
                nuevo_registro.ExecuteNonQuery();

                //CIERRO LA CONEXION
                mi_conexion.Close();

                Limpiar();

                MessageBox.Show("Agrego un registro satisfactoriamente");
            }

            //CRUD: LEER
            //VERIFICA CAMPOS DE BUSQUEDA
            if (chx_servicios.Checked || chx_fecha.Checked || chx_cliente.Checked)
            {
                if (rbn_leer.Checked) {

                    consulta = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD*S.PRECIOS AS TOTAL " + 
                               "FROM VENTAS AS V, CLIENTES AS C, SERVICIOS AS S " +
                               "WHERE V.ID_CLIENTE = C.ID_CLIENTE AND V.ID_SERVICIOS = S.ID_SERVICIOS";

                    if (chx_fecha.Checked)
                    {
                        consulta += " AND V.FECHA_VENTA LIKE '%" + fecha + "%'";
                    }
                    if (chx_cliente.Checked)
                    {
                        consulta += " AND V.ID_CLIENTE='" + id_cliente + "'";
                    }
                    if (chx_servicios.Checked)
                    {
                        consulta += " AND V.ID_SERVICIOS='" + id_servicio + "'";
                    }

                    //CARGA EL DATAGRID CON LA BUSQUEDA
                    SqlDataAdapter mostrar;
                    DataTable tabla = new DataTable();

                    //ABRO CONEXION
                    mi_conexion.Open();

                    //INSTRUCCION SQL
                    mostrar = new SqlDataAdapter (consulta, mi_conexion);
                    //LLENO LA TABLA
                    mostrar.Fill(tabla);

                    //CIERRO LA CONEXION
                    mi_conexion.Close();

                    //LLENO EL DATA GRID VIEW
                    dgw_ventas.DataSource = tabla;

                    Limpiar();
                    chx_cliente.Checked = true;
                }
            }
            //NO COMPLETO NINGUNO DE LOS CAMPOS REQUERIDOS
            else
            {
                Mensaje(2);
            }
        }

        //BOTON: SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btn_reportes_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            REPORTES reportes = new REPORTES();
            //LLAMA AL FORMULARIO
            reportes.Show();
        }


        //  ******************* FUNCIONES *******************
        void Mensaje (int id)
        {
            switch (id)
            {
                case 1: //NO HAY REGISTRO
                    MessageBox.Show("No encontramos ningún registro.");
                    break;
                case 2: //FALTAN CAMPOS
                    MessageBox.Show("Complete los campos requeridos.");
                    lbl_error_cliente.Visible = true;
                    lbl_error_fecha.Visible = true;
                    lbl_error_servicio.Visible = true;
                    break;
            }

        }

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_fecha.Text = "";
            txt_cantidad.Text = "";
            txt_oc.Text = "";
            cbx_cliente.Text = "";
            cbx_servicio.Text = "";
            chx_cliente.Checked = false;
            chx_fecha.Checked = false;
            chx_servicios.Checked = false;
            lbl_error_cliente.Visible = false;
            lbl_error_fecha.Visible = false;
            lbl_error_servicio.Visible = false;

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
    }
}
