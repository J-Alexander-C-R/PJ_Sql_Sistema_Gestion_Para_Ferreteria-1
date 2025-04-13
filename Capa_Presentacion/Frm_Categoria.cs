using Capa_Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Presentacion
{
    public partial class Frm_Categoria : Form
    {
        private CN_Categoria Logica_Categoria = new CN_Categoria(); // TODO: Instancia de la lógica de negocio para manejar categorías

        public Frm_Categoria()
        {
            InitializeComponent();
        }

        private void Frm_Categoria_Load(object sender, EventArgs e)
        {
            CargarProductos(); // TODO: Carga inicial de categorías en el DataGridView
            ConfigurarGrid();
        }

        private void CargarProductos()
        {
            try
            {
                dgv_Categoria.DataSource = Logica_Categoria.MostrarDatos(); // TODO: Obtiene las categorías desde la lógica y las muestra
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los productos", ex); // TODO: Este mensaje debería decir "categorías", no "productos"
            }
        }

        private void ConfigurarGrid()
        {
            dgv_Categoria.ReadOnly = true;
            dgv_Categoria.AllowUserToAddRows = false;
            dgv_Categoria.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Categoria.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimpiarCampos()
        {
            txt_Categoria.Clear(); // TODO: Limpia el campo de texto de categoría
        }

        private bool ValidarCampos(out string categoria)
        {
            categoria = txt_Categoria.Text;

            if (string.IsNullOrEmpty(categoria))
            {
                MostrarAdvertencia("Por favor rellene todos los campos.");
                return false;
            }
            return true;
        }

        private void dgv_Categoria_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgv_Categoria.Rows[e.RowIndex];
            txt_Categoria.Text = row.Cells["Categoria_Producto"].Value?.ToString() ?? ""; // TODO: Obtiene la categoría seleccionada y la muestra en el TextBox
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btn_Agregar_Categoria_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string categoria)) return;

            try
            {
                Logica_Categoria.AgregarDatos(categoria); // TODO: Agrega la nueva categoría usando la lógica
                CargarProductos();
                LimpiarCampos();
                MostrarInfo("Categoria agregado correctamente."); // TODO: "agregado" → "agregada"
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar la categoria", ex);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (HayCambios())
            {
                if (Confirmar("¿Está seguro de descartar los cambios?"))
                    LimpiarCampos(); // TODO: Limpia si el usuario confirma
            }
            else
            {
                LimpiarCampos(); // TODO: Limpia directamente si no hay cambios
            }
        }

        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idCategoria)) return;

            string nombre = dgv_Categoria.CurrentRow.Cells["Categoria"].Value?.ToString() ?? "categoria"; // TODO: El nombre de la categoría

            if (Confirmar($"¿Desea eliminar la categoria '{nombre}' (ID: {idCategoria})?"))
            {
                try
                {
                    Logica_Categoria.EliminarDatos(idCategoria); // TODO: Elimina la categoría seleccionada
                    CargarProductos();
                    LimpiarCampos();
                    MostrarInfo("Categoria eliminada correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al eliminar la categoria", ex);
                }
            }
        }

        private void btn_Editar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idCategoria)) return;
            if (!ValidarCampos(out string categoria)) return;

            if (Confirmar($"¿Desea guardar los cambios para la categoria ID: {idCategoria}?"))
            {
                try
                {
                    Logica_Categoria.EditarCategoria(categoria, idCategoria); // TODO: Edita la categoría en la base de datos
                    CargarProductos();
                    LimpiarCampos();
                    MostrarInfo("Categoria editada correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al editar la categoria", ex);
                }
            }
        }

        // Métodos Auxiliares -----------------------------------------------------------------------------------------------------

        private bool FilaSeleccionada(out int id)
        {
            id = -1;
            if (dgv_Categoria.CurrentRow?.Cells["IdCategoria"].Value == null ||
                !int.TryParse(dgv_Categoria.CurrentRow.Cells["IdCategoria"].Value.ToString(), out id))
            {
                return false;
            }
            return true;
        }

        private bool HayCambios()
        {
            return !string.IsNullOrEmpty(txt_Categoria.Text); // TODO: Devuelve true si el campo no está vacío (hay algo ingresado)
        }

        private bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        // Manejo de mensajes al usuario -----------------------------------------------------------------------------------------

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
    }
}
