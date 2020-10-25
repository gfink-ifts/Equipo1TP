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
            mostrar_servicios();
            mostrar_clientes();
            Limpiar();
        }

        //SELECTOR: ACTUALIZAR
        private void rbn_actualizar_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();
            Limpiar();
        }

        //SELECTOR: BORRAR
        private void rbn_borrar_CheckedChanged(object sender, EventArgs e)
        {
            mostrar_servicios();
            mostrar_clientes();
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
            string fecha = Convert.ToString(txt_fecha.Text);
            int id_cliente = cbx_cliente.SelectedIndex;
            int id_servicio = cbx_servicio.SelectedIndex;
            int cliente = id_cliente + 1;
            int servicio = id_servicio + 1;



            /*
             *    MessageBox.Show("TEXT: " + cbx_cliente.SelectedValue);
            MessageBox.Show("VALUE: " + cbx_cliente.SelectedText);
            MessageBox.Show("id cliente: " + id_cliente);
            MessageBox.Show("id servicios: " + id_servicio);
             *   MessageBox.Show("fecha: " + fecha);
            MessageBox.Show("cliente: " + cliente);
            MessageBox.Show("id cliente: " + id_cliente);
            MessageBox.Show("servicios: " + servicio);
            MessageBox.Show("id servicios: " + id_servicio);
                   MessageBox.Show("fecha: " + fecha);
            MessageBox.Show("cliente: " + cliente);
            MessageBox.Show("servicios: " + servicio);
             * 
            MessageBox.Show("SELECT: " + cbx_cliente.SelectedValue);
            MessageBox.Show("fecha: " + dtp_fecha);
            MessageBox.Show("fecha: "+fecha);
            MessageBox.Show("cliente: " + cliente);
            MessageBox.Show("servicios: " + servicio);
            */

            if (rbn_leer.Checked)
            {
                //FALTA DE ARGUMENTOS PARA BUSCAR
                if (fecha == "" && id_cliente == 0 && id_servicio == 0)
                {
                    Mensaje(2);
                    lbl_error_cliente.Visible = true;
                    lbl_error_fecha.Visible = true;
                    lbl_error_servicio.Visible = true;

                    mostrar_servicios();
                    mostrar_clientes();

                    Limpiar();

                    MessageBox.Show("NINGUNA");
                }
                //TODOS
                else if (fecha != "" && cbx_cliente.SelectedText != "" && cbx_servicio.SelectedText != "")
                {
                    if (cliente >= 1)
                    {
                        SqlDataAdapter mostrar;
                        DataTable tabla_ventas = new DataTable();

                        //ABRO CONEXION
                        mi_conexion.Open();

                        //INSTRUCCION SQL
                        mostrar = new SqlDataAdapter("SELECT * FROM VENTAS WHERE ID_CLIENTE=" + cliente + " AND ID_SERVICIOS=" + servicio +
                                                     " AND FECHA_VENTA LIKE '%" + fecha + "%'", mi_conexion);

                        //LLENO LA TABLA
                        mostrar.Fill(tabla_ventas);

                        //CIERRO LA CONEXION
                        mi_conexion.Close();

                        //LLENO EL DATA GRID VIEW
                        dgw_ventas.DataSource = tabla_ventas;

                        MessageBox.Show("TODOS");
                    }
                    else
                    {
                        Mensaje(1);
                    }
                    
                }
               //POR FECHA
               else if (fecha != "")
               {
                   SqlDataAdapter mostrar;
                   DataTable tabla_ventas = new DataTable();

                   //ABRO CONEXION
                   mi_conexion.Open();

                   //INSTRUCCION SQL
                   mostrar = new SqlDataAdapter("SELECT * FROM VENTAS WHERE FECHA_VENTA LIKE '%" + fecha + "%'", mi_conexion);

                   //LLENO LA TABLA
                   mostrar.Fill(tabla_ventas);

                   //CIERRO LA CONEXION
                   mi_conexion.Close();

                   //LLENO EL DATA GRID VIEW
                   dgw_ventas.DataSource = tabla_ventas;

                    MessageBox.Show("FECHA");
               }
               //POR CLIENTE
               else if (cliente != 0)
               {
                   SqlDataAdapter mostrar;
                   DataTable tabla_ventas = new DataTable();

                   //ABRO CONEXION
                   mi_conexion.Open();

                   //INSTRUCCION SQL
                   mostrar = new SqlDataAdapter("SELECT * FROM VENTAS WHERE ID_CLIENTE='" + cliente + "'", mi_conexion);

                   //LLENO LA TABLA
                   mostrar.Fill(tabla_ventas);

                   //CIERRO LA CONEXION
                   mi_conexion.Close();

                   //LLENO EL DATA GRID VIEW
                   dgw_ventas.DataSource = tabla_ventas;

                    MessageBox.Show("CLIENTE");
                }
               //POR SERVICIO
               else if (servicio != 0)
               {
                   SqlDataAdapter mostrar;
                   DataTable tabla_ventas = new DataTable();

                   //ABRO CONEXION
                   mi_conexion.Open();

                   //INSTRUCCION SQL
                   mostrar = new SqlDataAdapter("SELECT * FROM VENTAS WHERE ID_SERVICIOS='" + servicio + "'", mi_conexion);

                   //LLENO LA TABLA
                   mostrar.Fill(tabla_ventas);

                   //CIERRO LA CONEXION
                   mi_conexion.Close();

                   //LLENO EL DATA GRID VIEW
                   dgw_ventas.DataSource = tabla_ventas;

                    MessageBox.Show("SERVICIOS");
                }
               else
               {
                   Mensaje(1);
               }
            }
            /*
            //CRUD: ACTUALIZAR
            if (rbn_actualizar.Checked)
            {

            }

            //CRUD: BORRAR
            if (rbn_borrar.Checked)
            {

            }
            //MENSAJE DE ERROR 
           
            MessageBox.Show("Seleccione una de las \nopciones de arriba");
            */
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
        void Mensaje (int id)
        {
            switch (id)
            {
                case 1: //NO HAY REGISTRO
                    MessageBox.Show("No encontramos ningún registro.");
                    break;
                case 2: //FALTAN CAMPOS
                    MessageBox.Show("Complete los campos requeridos.");
                    break;
            }

        }

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
