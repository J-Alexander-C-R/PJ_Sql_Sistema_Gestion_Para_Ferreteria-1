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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.IsMdiContainer = true;
            Frm_Producto frm_Producto = new Frm_Producto();
            frm_Producto.MdiParent = this;
            frm_Producto.FormBorderStyle = FormBorderStyle.None;
            frm_Producto.Dock = DockStyle.Fill;
            frm_Producto.Show();

        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            
            Frm_Empleado frm_Empleado = new Frm_Empleado();
            frm_Empleado.ShowDialog();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Cliente frm_Cliente = new Frm_Cliente();
            frm_Cliente.Show();
        }

        private void btn_Categoria_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Categoria frm_categoria = new Frm_Categoria();
            frm_categoria.Show();
        }

        private void btn_Proveedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Proveedor frm_proveedor = new Frm_Proveedor();
            frm_proveedor.Show();
        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frm_Consulta frm_consulta = new Frm_Consulta();
            frm_consulta.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm_login = new Login();
            frm_login.Show();
        }
    }
}
