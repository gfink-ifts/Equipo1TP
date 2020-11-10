using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Equipo1
{
    public partial class PRINCIPAL_2 : Form
    {
        public PRINCIPAL_2()
        {
            InitializeComponent();
        }

        //BOTON: CLIENTES
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            CLIENTES cliente = new CLIENTES();
            //LLAMA AL FORMULARIO
            cliente.Show();
        }

        //BOTON: CONTACTOS
        private void btn_contactos_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            CONTACTOS contacto = new CONTACTOS();
            //LLAMA AL FORMULARIO
            contacto.Show();
        }

        //BOTON: PROVINCIAS
        private void btn_provincias_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PROVINCIAS provincias = new PROVINCIAS();
            //LLAMA AL FORMULARIO
            provincias.Show();
        }
        //BOTON: VENTAS
        private void btn_ventas_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            VENTAS ventas = new VENTAS();
            //LLAMA AL FORMULARIO
            ventas.Show();
        }

        //BOTON: PRODUCTOS
        private void btn_productos_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            SERVICIOS servicios = new SERVICIOS();
            //LLAMA AL FORMULARIO
            servicios.Show();
        }

        //BOTON: TIPO_PRODUCTOS
        private void btn_tipo_productos_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            TIPO_SERVICIOS tipo = new TIPO_SERVICIOS();
            //LLAMA AL FORMULARIO
            tipo.Show();
        }

        //BOTON: SALIR
        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
