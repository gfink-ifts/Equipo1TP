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
    public partial class PRINCIPAL : Form
    {
        string soy_un_string;
        public PRINCIPAL()
        {
            InitializeComponent();
        }

        private void PRINCIPAL_Load(object sender, EventArgs e)
        {

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PRINCIPAL_2 actualizar = new PRINCIPAL_2();
            //LLAMA AL FORMULARIO
            actualizar.Show();
        }

        private void btn_leer_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PRINCIPAL_2 leer = new PRINCIPAL_2();
            //LLAMA AL FORMULARIO
            leer.Show();
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PRINCIPAL_2 eliminar = new PRINCIPAL_2();
            //LLAMA AL FORMULARIO
            eliminar.Show();
        }

        private void btn_crear_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PRINCIPAL_2 crear = new PRINCIPAL_2();
            //LLAMA AL FORMULARIO
            crear.Show();
        }

        private void btn_consultas_reportes_Click(object sender, EventArgs e)
        {
            //DECLARACION DE LOS FORMULARIOS
            PRINCIPAL_2 reportes = new PRINCIPAL_2();
            //LLAMA AL FORMULARIO
            reportes.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
