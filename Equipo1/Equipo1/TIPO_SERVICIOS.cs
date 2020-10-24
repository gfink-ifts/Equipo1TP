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
    public partial class TIPO_SERVICIOS : Form
    {

        // CONEXION A LA BASE DE DATOS (patch / BBDD / seguridad)
        string conectar = @"data source=P528853\SQLEXPRESS; initial catalog= OUTSOURCING; integrated security= SSPI";
        //DEFINIMOS LA VARIABLE DE SqlConnection
        SqlConnection mi_conexion;


        //  ******************* FORMULARIO *******************
        public TIPO_SERVICIOS()
        {
            InitializeComponent();
        }

        private void TIPO_SERVICIOS_Load(object sender, EventArgs e)
        {
            //VARIABLE QUE ESTABLECERA LA CONEXION
            mi_conexion = new SqlConnection(conectar);
        }

        //BOTON: EJECUTAR
        private void btn_ejecutar_Click(object sender, EventArgs e)
        {
            //CRUD: CREAR
            if (rbn_crear.Checked)
            {
            }
            //CRUD: LEER
            if (rbn_crear.Checked)
            {
            }
            //CRUD: UPDATE
            if (rbn_crear.Checked)
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
            if (rbn_crear.Checked)
            {
            }

        }

      
        //FUNCION LIMPIAR
        void Limpiar()
        {
            
            txt_descripcion1.Text = "";
            
        }

        private void btn_salir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}


