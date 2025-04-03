using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Frm_Producto : Form
    {
        public Frm_Producto()
        {
            InitializeComponent();
            //TODO Se asigna como origen de datos del DataGridView (dgv_Producto) el resultado del método MostrarDatos().
            //TODO Este método pertenece a la capa lógica (Logica_Producto) y retorna un DataTable con los datos obtenidos de la base de datos.
            //TODO Al asignar el DataTable al DataSource, el DataGridView se llena automáticamente con los registros de la tabla Producto.
            dgv_Producto.DataSource = Logica_Producto.MostrarDatos();
        }

        private CN_Producto Logica_Producto = new CN_Producto();
        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            CN_Categoria categoria = new CN_Categoria();
            CN_Proveedor proveedor = new CN_Proveedor();
            cmb_Categoria.DataSource = categoria.MostrarCategorias();
            cmb_Categoria.DisplayMember = "Nombre_Categoria";
            cmb_Categoria.ValueMember = "Id_Categoria";

            cmb_Proveedor.DataSource = proveedor.MostrarProveedores();
            cmb_Proveedor.DisplayMember = "Nombre_Proveedor";
            cmb_Proveedor.ValueMember = "Id_Proveedor";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                // Capturar los valores de los controles
                string nombre = txt_Producto.Text;
                double precio = Convert.ToDouble(txt_Precio.Text);
                int stock = Convert.ToInt32(txt_Stock.Text);
                int idProveedor = Convert.ToInt32(cmb_Proveedor.SelectedValue);
                int idCategoria = Convert.ToInt32(cmb_Categoria.SelectedValue);

                // Crear instancia de la capa de negocios y agregar producto
                CN_Producto producto = new CN_Producto();
                producto.AgregarDatos(nombre, precio, stock, idProveedor, idCategoria);

                // Actualizar la tabla para mostrar el nuevo producto
                dgv_Producto.DataSource = producto.MostrarDatos();

                // Mensaje de confirmación
                MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos después de agregar
                txt_Producto.Clear();
                txt_Precio.Clear();
                txt_Stock.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
