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
    public partial class REPORTES : Form
    {
        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=DV3458-FUSTARIZ\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;

        //DECLARACION TABLE
        DataTable tabla = new DataTable();
        
        public REPORTES()
        {
            InitializeComponent();
        }

        private void REPORTES_Load(object sender, EventArgs e)
        {
            string mostrar = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                             "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                             "wHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS";

            Llenar_dgw(mostrar);

            btn_buscar.Visible = false;
            gbx_fecha.Visible = false;

            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);

        }

        //SELECTOR
        private void rbn_fecha_CheckedChanged(object sender, EventArgs e)
        {
            //VISIBILIDAD DE VARIABLES
            btn_buscar.Visible = true;
            gbx_fecha.Visible = true;
            Limpiar();
        }

        private void rbn_cliente_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            tabla = new DataTable();

            string mostrar = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                 "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                 "wHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS";

            //VISIBILIDAD DE VARIABLES
            btn_buscar.Visible = false;
            gbx_fecha.Visible = false;

            Llenar_dgw(mostrar);
            Max(tabla, 4, 1);
            Min(tabla, 4, 1);
        }

        private void rbn_producto_CheckedChanged(object sender, EventArgs e)
        {
            Limpiar();
            tabla = new DataTable();
            
            string mostrar = "SELECT S.descripcion, COUNT(CANTIDAD)" +
                             "FROM VENTAS AS V, SERVICIOS AS S " +
                             "GROUP BY s.descripcion";

            //VISIBILIDAD DE VARIABLES
            btn_buscar.Visible = false;
            gbx_fecha.Visible = false;

            Llenar_dgw(mostrar);
            Max(tabla, 1, 0);
            Min(tabla, 1, 0);
        }


        // ************************************************* BOTONES *************************************************
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            tabla.Clear();

            string ano = cbx_ano.SelectedItem.ToString();
            string mes;
            string instruccion = " ";

            if (cbx_mes.SelectedIndex == 0)
            {
                mes = " ";
            }
            else if (cbx_mes.SelectedIndex == 10 || cbx_mes.SelectedIndex == 11 || cbx_mes.SelectedIndex == 12)
            {
                mes = cbx_mes.SelectedIndex.ToString();
            }
            else
            {
                mes = "0" + cbx_mes.SelectedIndex.ToString();
            }

            if (rbn_cliente_2.Checked)
            {
                instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                              "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                              "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND " +
                              "fecha_venta LIKE '%" + ano + "-" + mes + "%' ORDER BY FECHA_VENTA DESC";
            }
            else
            {
                instruccion = "SELECT S.descripcion, COUNT(CANTIDAD)" +
                              "FROM VENTAS AS V, SERVICIOS AS S " +
                              "WHERE fecha_venta LIKE '%" + ano + "-" + mes + "%'" +
                              "GROUP BY s.descripcion";
            }  

            //LLAMADO A LA FUNCION
            Llenar_dgw(instruccion);

            //CALCULO CON MATRIZ
            if (rbn_cliente_2.Checked)
            {
                Max(tabla, 4, 1);
                Min(tabla, 4, 1);
            }
            else
            {
                Max(tabla, 1, 0);
                Min(tabla, 1, 0);
            }
        }

            //BOTON CERRAR
            private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ************************************************* FUNCIONES *************************************************
                
        void Max (DataTable dl, int columna, int desc)
        {
            int maximo = 0;
            string nombre = " ";

            for (int i = 0; i < dl.Rows.Count; i++)
            {
                if (Convert.ToInt32(dl.Rows[i][columna]) > maximo)
                {
                    maximo = Convert.ToInt32(dl.Rows[i][columna]);
                    nombre = dl.Rows[i][desc].ToString();
                }
            }
            lbl_mejor_nombre.Text = Convert.ToString(nombre);
            lbl_mejor_total.Text = Convert.ToString(maximo);
        }

        void Min (DataTable dl, int columna, int desc)
        {
            int minimo = 10000;
            string nombre = " ";

            for (int i = 0; i < dl.Rows.Count; i++)
            {
                if (Convert.ToInt32(dl.Rows[i][columna]) < minimo)
                {
                    minimo = Convert.ToInt32(dl.Rows[i][columna]);
                    nombre = dl.Rows[i][desc].ToString();
                }
            }
            lbl_peor_nombre.Text = Convert.ToString(nombre);
            lbl_peor_total.Text = Convert.ToString(minimo);
        }

        void Llenar_dgw(string consulta)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);

            //GENERO UNA INSTANCIA DE TABLE
            tabla = new DataTable();

            //VARIABLE DONDE ALMACENO LA INSTRUCCION SQL
            SqlDataAdapter mostrar;
            //ABRO LA CONEXION
            mi_conexion.Open();
            //INSTRUCCION SQL
            mostrar = new SqlDataAdapter(consulta, mi_conexion);

            //CARGA DE LA TABLA
            mostrar.Fill(tabla);
            //CIERRO LA CONEXION
            mi_conexion.Close();
            //CARGO EL DATA GRID VIEW
            dgw_reportes.DataSource = tabla;

        }

        void Limpiar()
        {
            lbl_mejor_nombre.Text = " ";
            lbl_mejor_total.Text = " ";
            lbl_peor_nombre.Text = " ";
            lbl_peor_total.Text = " ";
        }
    }
}

