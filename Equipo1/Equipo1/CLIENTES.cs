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
        string conectar = @"data source=DESKTOP-6NP4PUO\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
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
        private void btn_Ejecutar_Click(object sender, EventArgs e)
        {
            //CRUD: CREAR
            if (rbn_Crear.Checked)
            {
            }
            //CRUD: LEER
            if (rbn_Leer.Checked)
            {
                mostrar_clientes();
            }
            //CRUD: UPDATE
            if (rbn_Crear.Checked)
            {
                /*

                SqlDataAdapter llenar_combo;

                DataTable tabla_cat_cliente = new DataTable();

                mi_conexion.Open();

                mostrar_por = new SqlDataAdapter("select * from clientes where direccion LIKE '%" + buscar + "%'", mi_conexion);

                mostrar_por.Fill(tabla_cat_cliente);

                mi_conexion.Close();
                */


            }
            //CRUD: DELETE
            if (rbn_Crear.Checked)
            {
            }

        }
              

        //FUNCION LIMPIAR
        void Limpiar()
        {
            txt_nombre.Text = "";
            txt_area.Text = "";
            txt_idcontacto.Text = "";
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

    }
}
