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
    public partial class Frm_Empleado : Form
    {
        private CN_Empleado datagv_Empleado = new CN_Empleado();
        public Frm_Empleado()
        {
            InitializeComponent();
            dgv_Empleado.DataSource = datagv_Empleado.MostrarDatos();
        }

     
    }
}
