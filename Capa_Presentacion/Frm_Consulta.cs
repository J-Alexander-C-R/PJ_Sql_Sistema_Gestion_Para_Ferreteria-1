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
    public partial class Frm_Consulta : Form
    {

        private readonly CN_Producto Logica_Producto = new CN_Producto();
        private readonly CN_Categoria Logica_Categoria = new CN_Categoria();
        private readonly CN_Proveedor Logica_Proveedor = new CN_Proveedor();
        private readonly CN_Empleado Logica_Empleado = new CN_Empleado();
        private readonly CN_Cliente Logica_Cliente = new CN_Cliente();

        public Frm_Consulta()
        {
            InitializeComponent();
        }

        private void ConfigurarGrid()
        {
            dgv_conulta.ReadOnly = true;
            dgv_conulta.AllowUserToAddRows = false;
            dgv_conulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_conulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void Frm_Consulta_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgv_conulta.DataSource = Logica_Producto.MostrarDatos();
            ConfigurarGrid();

        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {
            dgv_conulta.DataSource = Logica_Empleado.MostrarDatos();
            ConfigurarGrid();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgv_conulta.DataSource = Logica_Cliente.MostrarDatos();
            ConfigurarGrid();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgv_conulta.DataSource = Logica_Proveedor.MostrarDatos();
            ConfigurarGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dgv_conulta.DataSource = Logica_Categoria.MostrarDatos();
            ConfigurarGrid();
        }
    }
}
