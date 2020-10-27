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
        string cadenaConnex = @"data source=DESKTOP-E2DA7HR\SQLEXPRESS; initial catalog='outsourcingv01'; integrated security=SSPI";
        SqlConnection cn;

        //formulario
        public CONTACTOS()
        {
            InitializeComponent();
        }

        private void CONTACTOS_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(cadenaConnex);
        }
        //funciones
        void Limpiar()
        {
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Domicilio.Text = "";
            txt_Id_Provincia.Text = "";
            txt_Telefono.Text = "";
            txt_Mail.Text = "";
        }
        //botones
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Ejecutar_Click(object sender, EventArgs e)
		{

		}

		
	}
}
