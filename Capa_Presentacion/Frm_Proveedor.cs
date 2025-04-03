using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Proveedor : Form
    {
        private CN_Proveedor Logica_Proveedor = new CN_Proveedor();
        public Frm_Proveedor()
        {
            InitializeComponent();
            dgv_Proveedor.DataSource = Logica_Proveedor.MostrarDatos();

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {

        }
    }
}
