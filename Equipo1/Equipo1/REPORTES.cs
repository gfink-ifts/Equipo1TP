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
        /*
        string mostrar = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                         "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                         "wHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS";
                         */
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
            string mostrar = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                 "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                 "wHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS";

            //VISIBILIDAD DE VARIABLES
            btn_buscar.Visible = false;
            gbx_fecha.Visible = false;

            Llenar_dgw(mostrar);
            Max(tabla, 4,1);
            Min(tabla, 4, 1);
            Limpiar();
        }

        private void rbn_producto_CheckedChanged(object sender, EventArgs e)
        {
            string mostrar = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                 "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                 "wHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS";

            //VISIBILIDAD DE VARIABLES
            btn_buscar.Visible = false;
            gbx_fecha.Visible = false;

            Llenar_dgw(mostrar);
            Max(tabla, 4, 2);
            Min(tabla, 4, 2);
            Limpiar();
        }


        // ************************************************* BOTONES *************************************************
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            tabla.Clear();

            string ano = cbx_ano.SelectedItem.ToString();
            string mes;
            string instruccion = " ";

            if (cbx_mes.SelectedItem is null)
            {
                mes = "0";
            }
            else
            {
                mes = cbx_mes.SelectedItem.ToString();
            }
            //MessageBox.Show(mes);

            //CONSULTA SQL
            if (ano == "2020")
            {
                if (mes == "0")
                {
                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-12-31' " +
                                  "AND FECHA_VENTA<'2021-01-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "01")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-12-31' " +
                                  "AND FECHA_VENTA<'2020-02-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "02")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-01-31' " +
                                  "AND FECHA_VENTA<'2020-03-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "03")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-02-31' " +
                                  "AND FECHA_VENTA<'2020-04-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "04")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-03-31' " +
                                  "AND FECHA_VENTA<'2020-05-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "05")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-04-31' " +
                                  "AND FECHA_VENTA<'2020-06-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "07")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-06-31' " +
                                  "AND FECHA_VENTA<'2020-08-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "08")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-07-31' " +
                                  "AND FECHA_VENTA<'2020-09-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "09")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-08-31' " +
                                  "AND FECHA_VENTA<'2020-10-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "10")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-09-31' " +
                                  "AND FECHA_VENTA<'2020-11-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "11")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-10-31' " +
                                  "AND FECHA_VENTA<'2020-12-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "12")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2020-11-31' " +
                                  "AND FECHA_VENTA<'2021-01-01' ORDER BY FECHA_VENTA DESC";
                }
            }
            else if (ano == "2019")
            {
                if (mes == "0")
                {
                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-12-31' " +
                                  "AND FECHA_VENTA<'2020-01-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "01")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-12-31' " +
                                  "AND FECHA_VENTA<'2019-02-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "02")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-01-31' " +
                                  "AND FECHA_VENTA<'2019-03-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "03")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-02-31' " +
                                  "AND FECHA_VENTA<'2019-04-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "04")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-03-31' " +
                                  "AND FECHA_VENTA<'2019-05-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "05")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-04-31' " +
                                  "AND FECHA_VENTA<'2019-06-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "07")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-06-31' " +
                                  "AND FECHA_VENTA<'2019-08-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "08")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-07-31' " +
                                  "AND FECHA_VENTA<'2019-09-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "09")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-08-31' " +
                                  "AND FECHA_VENTA<'2019-10-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "10")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-09-31' " +
                                  "AND FECHA_VENTA<'2019-11-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "11")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-10-31' " +
                                  "AND FECHA_VENTA<'2019-12-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "12")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2019-11-31' " +
                                  "AND FECHA_VENTA<'2020-01-01' ORDER BY FECHA_VENTA DESC";
                }

            }
            else if (ano == "2018")
            {
                if (mes == "0")
                {
                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                       "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                       "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-12-31' " +
                       "AND FECHA_VENTA<'2019-01-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "01")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-12-31' " +
                                  "AND FECHA_VENTA<'2018-02-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "02")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-01-31' " +
                                  "AND FECHA_VENTA<'2018-03-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "03")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-02-31' " +
                                  "AND FECHA_VENTA<'2018-04-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "04")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-03-31' " +
                                  "AND FECHA_VENTA<'2018-05-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "05")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-04-31' " +
                                  "AND FECHA_VENTA<'2018-06-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "07")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-06-31' " +
                                  "AND FECHA_VENTA<'2018-08-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "08")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-07-31' " +
                                  "AND FECHA_VENTA<'2018-09-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "09")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-08-31' " +
                                  "AND FECHA_VENTA<'2018-10-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "10")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-09-31' " +
                                  "AND FECHA_VENTA<'2018-11-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "11")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-10-31' " +
                                  "AND FECHA_VENTA<'2018-12-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "12")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2018-11-31' " +
                                  "AND FECHA_VENTA<'2019-01-01' ORDER BY FECHA_VENTA DESC";
                }
            }
            else if (ano == "2017")
            {
                if (mes == "0")
                {
                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                   "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                   "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-12-31' " +
                   "AND FECHA_VENTA<'2018-01-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "01")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-12-31' " +
                                  "AND FECHA_VENTA<'2017-02-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "02")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-01-31' " +
                                  "AND FECHA_VENTA<'2017-03-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "03")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-02-31' " +
                                  "AND FECHA_VENTA<'2017-04-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "04")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-03-31' " +
                                  "AND FECHA_VENTA<'2017-05-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "05")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-04-31' " +
                                  "AND FECHA_VENTA<'2017-06-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "07")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-06-31' " +
                                  "AND FECHA_VENTA<'2017-08-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "08")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-07-31' " +
                                  "AND FECHA_VENTA<'2017-09-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "09")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-08-31' " +
                                  "AND FECHA_VENTA<'2017-10-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "10")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-09-31' " +
                                  "AND FECHA_VENTA<'2017-11-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "11")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-10-31' " +
                                  "AND FECHA_VENTA<'2017-12-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "12")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2017-11-31' " +
                                  "AND FECHA_VENTA<'2018-01-01' ORDER BY FECHA_VENTA DESC";
                }
            }
            else
            {
                if (mes == "0")
                {
                        instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                   "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                   "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2015-12-31' " +
                   "AND FECHA_VENTA<'2017-01-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "01")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2015-12-31' " +
                                  "AND FECHA_VENTA<'2016-02-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "02")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-01-31' " +
                                  "AND FECHA_VENTA<'2016-03-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "03")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-02-31' " +
                                  "AND FECHA_VENTA<'2016-04-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "04")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-03-31' " +
                                  "AND FECHA_VENTA<'2016-05-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "05")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-04-31' " +
                                  "AND FECHA_VENTA<'2016-06-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "07")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-06-31' " +
                                  "AND FECHA_VENTA<'2016-08-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "08")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-07-31' " +
                                  "AND FECHA_VENTA<'2016-09-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "09")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-08-31' " +
                                  "AND FECHA_VENTA<'2016-10-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "10")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-09-31' " +
                                  "AND FECHA_VENTA<'2016-11-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "11")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-10-31' " +
                                  "AND FECHA_VENTA<'2016-12-01' ORDER BY FECHA_VENTA DESC";
                }
                else if (mes == "12")
                {

                    instruccion = "SELECT V.FECHA_VENTA, C.NOMBRE, S.DESCRIPCION, V.CANTIDAD, CANTIDAD*PRECIOS AS TOTAL " +
                                  "FROM CLIENTES AS C, SERVICIOS AS S, VENTAS AS V " +
                                  "WHERE C.ID_CLIENTE = V.ID_CLIENTE AND S.ID_SERVICIOS = V.ID_SERVICIOS AND fecha_venta> '2016-11-31' " +
                                  "AND FECHA_VENTA<'2017-01-01' ORDER BY FECHA_VENTA DESC";
                }
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
                Max(tabla, 4, 2);
                Min(tabla, 4, 2);
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

