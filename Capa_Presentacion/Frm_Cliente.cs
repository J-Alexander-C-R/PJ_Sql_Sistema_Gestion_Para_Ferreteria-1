using Capa_Negocios;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Cliente : Form
    {
        private CN_Cliente Logica_Cliente = new CN_Cliente(); // TODO: Instancia de la capa de lógica para manejar operaciones de cliente

        public Frm_Cliente()
        {
            InitializeComponent(); // TODO: Inicialización del formulario y sus componentes
        }

        private void Frm_Cliente_Load_1(object sender, EventArgs e)
        {
            CargarClientes(); // TODO: Carga inicial de datos en el DataGridView al iniciar el formulario
            LimpiarCampos();  // TODO: Limpia los campos del formulario al cargar
            ConfigurarGrid(); // TODO: Aplica configuraciones visuales al DataGridView
        }

        private void CargarClientes()
        {
            try
            {
                dgv_Cliente.DataSource = Logica_Cliente.MostrarDatos(); // TODO: Obtiene los clientes desde la lógica y los muestra
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los clientes", ex); // TODO: Muestra mensaje si ocurre error al cargar
            }
        }

        private void ConfigurarGrid()
        {
            dgv_Cliente.ReadOnly = true;
            dgv_Cliente.AllowUserToAddRows = false;
            dgv_Cliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Cliente.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dgv_Cliente.Rows[e.RowIndex];

            txt_Nombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
            txt_Apellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";

            if (long.TryParse(row.Cells["Telefono"].Value?.ToString(), out long telefono))
                txt_Telefono.Text = telefono.ToString();

            txt_Email.Text = row.Cells["Email"].Value?.ToString();
            txt_Direccion.Text = row.Cells["Direccion"].Value?.ToString();
        }

        private void LimpiarCampos()
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Telefono.Clear();
            txt_Email.Clear();
            txt_Direccion.Clear();
        }

        private bool ValidarCampos(out string nombre, out string apellido, out long telefono, out string email, out string direccion)
        {
            nombre = txt_Nombre.Text.Trim();
            apellido = txt_Apellido.Text.Trim();
            string telefonoTexto = txt_Telefono.Text.Trim();
            email = txt_Email.Text.Trim();
            direccion = txt_Direccion.Text.Trim();
            telefono = 0;

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) ||
                string.IsNullOrWhiteSpace(telefonoTexto) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(direccion))
            {
                MostrarAdvertencia("Por Favor Rellene todos los campos del formulario.");
                return false;
            }

            if (!long.TryParse(telefonoTexto, out telefono) || telefono <= 0)
            {
                MostrarAdvertencia("Ingrese un número de teléfono válido.");
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MostrarAdvertencia("Ingrese una dirección de Email válida.");
                return false;
            }

            if (CorreoDuplicado(email)) // TODO: Valida que no se repita el correo en la base
            {
                MostrarAdvertencia("Ya existe un cliente con ese correo electrónico.");
                return false;
            }

            if (telefonoTexto.Length <= 8)
            {
                MostrarAdvertencia("El número de teléfono debe tener más de 8 dígitos.");  // TODO: Advertir si el teléfono tiene menos de 8 dígitos
                return false;
            }

            return true;
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

        private void btn_Agregar_Cliente_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string nombre, out string apellido, out long telefono, out string email, out string direccion)) return;

            try
            {
                Logica_Cliente.AgregarDatos(nombre, apellido, telefono, email, direccion); // TODO: Llama a la lógica para agregar cliente
                CargarClientes();
                LimpiarCampos();
                MostrarInfo("Cliente agregado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar el cliente", ex);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (HayCambios()) // TODO: Verifica si hay cambios antes de limpiar
            {
                LimpiarCampos();
            }
            else
            {
                LimpiarCampos(); // TODO: Limpia siempre, pero se deja lógica para posible uso futuro
            }
        }

        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idCliente)) return;

            string nombre = dgv_Cliente.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "cliente";

            if (Confirmar($"¿Desea eliminar al cliente '{nombre}' (ID: {idCliente})?"))
            {
                try
                {
                    Logica_Cliente.EliminarDatos(idCliente); // TODO: Llama a la lógica para eliminar el cliente
                    CargarClientes();
                    LimpiarCampos();
                    MostrarInfo("Cliente eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al eliminar el cliente", ex);
                }
            }
        }

        private void btn_Editar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idCliente)) return;

            if (!ValidarCampos(out string nombre, out string apellido, out long telefono, out string email, out string direccion)) return;

            if (Confirmar($"¿Desea guardar los cambios para el cliente ID: {idCliente}?"))
            {
                try
                {
                    Logica_Cliente.EditarDatos(idCliente, nombre, apellido, telefono, email, direccion); // TODO: Llama a la lógica para actualizar cliente
                    CargarClientes();
                    LimpiarCampos();
                    MostrarInfo("Cliente editado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al editar el cliente", ex);
                }
            }
        }

        // Métodos Usados ------------------------------------------------------------------------------------------------------

        private bool HayCambios()
        {
            return !string.IsNullOrEmpty(txt_Nombre.Text) || !string.IsNullOrEmpty(txt_Apellido.Text)
                   || !string.IsNullOrEmpty(txt_Telefono.Text) || !string.IsNullOrEmpty(txt_Email.Text)
                   || !string.IsNullOrEmpty(txt_Direccion.Text);
        }

        private bool FilaSeleccionada(out int id)
        {
            id = -1;
            if (dgv_Cliente.CurrentRow?.Cells["IdCliente"].Value == null ||
                !int.TryParse(dgv_Cliente.CurrentRow.Cells["IdCliente"].Value.ToString(), out id))
            {
                MostrarAdvertencia("Seleccione un cliente válido de la lista.");
                return false;
            }
            return true;
        }

        private bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private bool CorreoDuplicado(string email)
        {
            DataTable correos = Logica_Cliente.ObtenerCorreos(); // TODO: Consulta los correos ya registrados para validar duplicados
            return correos.AsEnumerable().Any(row =>
                string.Equals(row["Email"].ToString(), email, StringComparison.OrdinalIgnoreCase));
        }

        // Métodos de Advertencias, Errores e Información -------------------------------------------------------------------------------

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
