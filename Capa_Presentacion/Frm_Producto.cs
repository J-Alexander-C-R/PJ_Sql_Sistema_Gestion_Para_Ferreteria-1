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
    public partial class Frm_Producto : Form
    {
        public Frm_Producto()
        {
            InitializeComponent();
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Empleado frmSecondary = new Frm_Empleado();
            frmSecondary.Show();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Cliente frm_terciary = new Frm_Cliente();
            frm_terciary.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
