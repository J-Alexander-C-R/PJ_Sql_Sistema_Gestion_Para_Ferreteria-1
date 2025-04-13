using System;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Capa_Negocios;

namespace Capa_Presentacion
{
    public partial class Frm_Producto : Form
    {
        private readonly CN_Producto Logica_Producto = new CN_Producto();
        private readonly CN_Categoria Logica_Categoria = new CN_Categoria();
        private readonly CN_Proveedor Logica_Proveedor = new CN_Proveedor();

        public Frm_Producto()
        {
            InitializeComponent();
        }

        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            CargarProductos(); //TODO: Método para cargar los productos desde la base de datos
            CargarCombos(); //TODO: Método para cargar las categorías y proveedores en los combos
            ConfigurarGrid(); //TODO: Método para configurar el DataGridView
        }

        private void ConfigurarGrid()
        {
            dgv_Producto.ReadOnly = true;
            dgv_Producto.AllowUserToAddRows = false;
            dgv_Producto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Producto.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void CargarProductos()
        {
            try
            {
                dgv_Producto.DataSource = Logica_Producto.MostrarDatos(); //TODO: Cargar la lista de productos desde la lógica de negocio
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los productos", ex); //TODO: Captura de errores al cargar productos
            }
        }

        private void CargarCombos()
        {
            CargarCombo(cmb_Categoria, Logica_Categoria.MostrarCategorias(), "Categoria", "IdCategoria"); //TODO: Llenar combo con las categorías
            CargarCombo(cmb_Proveedor, Logica_Proveedor.MostrarProveedores(), "Empresa", "IdProveedor"); //TODO: Llenar combo con los proveedores
        }

        private void CargarCombo(ComboBox combo, DataTable tabla, string display, string value)
        {
            if (tabla != null)
            {
                combo.DataSource = tabla;
                combo.DisplayMember = display;
                combo.ValueMember = value;
                combo.SelectedIndex = -1;
            }
        }

        private void LimpiarCampos()
        {
            txt_Producto.Clear();
            txt_Precio.Clear();
            txt_Stock.Clear();
            cmb_Categoria.SelectedIndex = -1;
            cmb_Proveedor.SelectedIndex = -1;
            txt_Producto.Focus();
        }

        private bool ValidarCampos(out string nombre, out double precio, out int stock, out int idCategoria, out int idProveedor)
        {
            nombre = txt_Producto.Text.Trim();
            precio = 0;
            stock = 0;
            idCategoria = idProveedor = -1;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(txt_Precio.Text) || string.IsNullOrWhiteSpace(txt_Stock.Text))
            {
                MostrarAdvertencia("Por favor rellene los campos Nombre, Precio y Stock.");
                return false;
            }

            string precioTexto = txt_Precio.Text.Replace(",", "."); //TODO: Reemplazar coma por punto para asegurar que el formato sea correcto

            if (!double.TryParse(precioTexto, NumberStyles.Any, CultureInfo.InvariantCulture, out precio) || precio < 0)
            {
                MostrarAdvertencia("Ingrese un precio válido");
                return false;
            }

            if (!int.TryParse(txt_Stock.Text, out stock) || stock < 0)
            {
                MostrarAdvertencia("Ingrese un stock válido.");
                return false;
            }

            if (cmb_Categoria.SelectedValue == null || cmb_Proveedor.SelectedValue == null)
            {
                MostrarAdvertencia("Debe seleccionar un proveedor y una categoría válidos.");
                return false;
            }

            idCategoria = Convert.ToInt32(cmb_Categoria.SelectedValue); //TODO: Obtener el ID de la categoría seleccionada
            idProveedor = Convert.ToInt32(cmb_Proveedor.SelectedValue); //TODO: Obtener el ID del proveedor seleccionado

            return true;
        }

        private void dgv_Producto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_Producto.Rows[e.RowIndex];

            txt_Producto.Text = row.Cells["NombreProducto"].Value?.ToString() ?? "";

            if (double.TryParse(row.Cells["Precio"].Value?.ToString(), NumberStyles.Any, CultureInfo.InvariantCulture, out double precio))
                txt_Precio.Text = precio.ToString("F2", CultureInfo.InvariantCulture);
            else
                txt_Precio.Clear();

            txt_Stock.Text = row.Cells["Stock"].Value?.ToString() ?? "";

            cmb_Categoria.SelectedValue = row.Cells["IdCategoria"].Value ?? -1;
            cmb_Proveedor.SelectedValue = row.Cells["IdProveedor"].Value ?? -1;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string nombre, out double precio, out int stock, out int idCategoria, out int idProveedor)) return;

            try
            {
                Logica_Producto.AgregarDatos(nombre, precio, stock, idCategoria, idProveedor); //TODO: Llamada a la lógica de negocio para agregar un producto
                CargarProductos(); //TODO: Recargar los productos para mostrar el nuevo producto en el DataGridView
                LimpiarCampos(); //TODO: Limpiar los campos después de agregar el producto
                MostrarInfo("Producto agregado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar el producto", ex);
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idProducto)) return;

            if (!ValidarCampos(out string nombre, out double precio, out int stock, out int idCategoria, out int idProveedor)) return;

            if (Confirmar($"¿Desea guardar los cambios para el producto ID: {idProducto}?"))
            {
                try
                {
                    Logica_Producto.EditarDatos(nombre, precio, stock, idCategoria, idProveedor, idProducto); //TODO: Llamada a la lógica de negocio para editar el producto
                    CargarProductos(); //TODO: Recargar los productos para mostrar el producto editado
                    LimpiarCampos(); //TODO: Limpiar los campos después de editar el producto
                    MostrarInfo("Producto editado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al editar el producto", ex);
                }
            }
        }

        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idProducto)) return;

            string nombre = dgv_Producto.CurrentRow.Cells["NombreProducto"].Value?.ToString() ?? "producto";

            if (Confirmar($"¿Desea eliminar el producto '{nombre}')?"))
            {
                try
                {
                    Logica_Producto.EliminarDatos(idProducto); //TODO: Llamada a la lógica de negocio para eliminar el producto
                    CargarProductos(); //TODO: Recargar los productos para mostrar la lista actualizada
                    LimpiarCampos(); //TODO: Limpiar los campos después de eliminar el producto
                    MostrarInfo("Producto eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al eliminar el producto", ex);
                }
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (HayCambios()) //TODO: Verificar si hay cambios en los campos antes de cancelar
            {
                if (Confirmar("¿Está seguro de descartar los cambios?")) //TODO: Preguntar al usuario si está seguro de descartar los cambios
                    LimpiarCampos(); //TODO: Limpiar los campos si el usuario confirma
            }
            else
            {
                LimpiarCampos(); //TODO: Limpiar los campos sin confirmar si no hay cambios
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e) => Close(); //TODO: Cerrar el formulario al hacer clic en el ícono de la imagen

        private bool FilaSeleccionada(out int id)
        {
            id = -1;
            if (dgv_Producto.CurrentRow?.Cells["IdProducto"].Value == null || !int.TryParse(dgv_Producto.CurrentRow.Cells["IdProducto"].Value.ToString(), out id)) //TODO: Verificar si la fila seleccionada es válida
            {
                MostrarAdvertencia("Seleccione un producto válido de la lista.");
                return false;
            }
            return true;
        }

        private bool HayCambios()
        {
            return !string.IsNullOrWhiteSpace(txt_Producto.Text) || !string.IsNullOrWhiteSpace(txt_Precio.Text) ||
                   !string.IsNullOrWhiteSpace(txt_Stock.Text) || cmb_Categoria.SelectedIndex > -1 || cmb_Proveedor.SelectedIndex > -1; //TODO: Verificar si hay cambios en los campos
        }

        private bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void MostrarInfo(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show($"{mensaje}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (HayCambios())  // TODO: Verificar si hay cambios en los campos
            {
                MostrarAdvertencia("Complete el proceso antes de salir");
            }
            else
            {
                this.Close();
            }
        }
    }
}
