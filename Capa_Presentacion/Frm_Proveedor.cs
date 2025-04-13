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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Presentacion
{
    public partial class Frm_Proveedor : Form
    {
        private CN_Proveedor Logica_Proveedor = new CN_Proveedor();
        public Frm_Proveedor()
        {
            InitializeComponent();
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {
            CargarProveedores();  // TODO: Cargar los proveedores al cargar el formulario
            LimpiarCampos();      // TODO: Limpiar los campos de texto del formulario
            ConfigurarGrid();     // TODO: Configurar las propiedades del DataGridView
        }

        public void CargarProveedores()
        {
            try
            {
                dgv_Proveedor.DataSource = Logica_Proveedor.MostrarDatos();  // TODO: Cargar la lista de proveedores desde la base de datos
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los proveedores", ex);  // TODO: Mostrar mensaje de error en caso de fallo
            }
        }

        private void ConfigurarGrid()
        {
            dgv_Proveedor.ReadOnly = true;
            dgv_Proveedor.AllowUserToAddRows = false;               
            dgv_Proveedor.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv_Proveedor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dgv_Proveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; 
            var row = dgv_Proveedor.Rows[e.RowIndex];

            txt_Empresa.Text = row.Cells["Empresa"].Value?.ToString() ?? "";  // TODO: Asignar el valor de la celda "Empresa" al campo correspondiente
            if (long.TryParse(row.Cells["Telefono"].Value?.ToString(), out long telefono))
                txt_Telefono.Text = telefono.ToString();  // TODO: Asignar el valor del teléfono si es válido

            txt_Email.Text = row.Cells["Email"].Value?.ToString();  // TODO: Asignar el valor del email
            txt_Direccion.Text = row.Cells["Direccion"].Value?.ToString();  // TODO: Asignar el valor de la dirección
        }

        private void LimpiarCampos()
        {
            txt_Empresa.Clear();  
            txt_Telefono.Clear();  
            txt_Email.Clear();     
            txt_Direccion.Clear(); 
        }

        private bool ValidarCampos(out string empresa, out long telefono, out string email, out string direccion)
        {
            // TODO: Obtener los valores ingresados por el usuario y validar
            empresa = txt_Empresa.Text.Trim();
            string telefonoTexto = txt_Telefono.Text.Trim();
            email = txt_Email.Text.Trim();
            direccion = txt_Direccion.Text.Trim();
            telefono = 0;

            if (string.IsNullOrWhiteSpace(empresa) || string.IsNullOrEmpty(telefonoTexto) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(direccion))
            {
                MostrarAdvertencia("Por Favor Rellene todos los campos del formulario.");  // TODO: Mostrar advertencia si algún campo está vacío
                return false;
            }

            if (!long.TryParse(telefonoTexto, out telefono) || telefono <= 0)
            {
                MostrarAdvertencia("Ingrese un numero de telefono valido. Sea Serio");  // TODO: Mostrar advertencia si el teléfono no es válido
                return false;
            }

            if (!email.Contains("@") || !email.Contains("."))
            {
                MostrarAdvertencia("Ingrese una direccion de Email Valida.");  // TODO: Mostrar advertencia si el email no es válido
                return false;
            }

            if (telefonoTexto.Length <= 8)
            {
                MostrarAdvertencia("El número de teléfono debe tener más de 8 dígitos.");  // TODO: Advertir si el teléfono tiene menos de 8 dígitos
                return false;
            }

            if (CorreoDuplicado(email))
            {
                MostrarAdvertencia("Ya existe un proveedor con ese correo electrónico.");  // TODO: Advertir si ya existe un proveedor con el mismo correo
                return false;
            }

            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            if (Haycambios())  // TODO: Verificar si hay cambios en los campos
            {
                MostrarAdvertencia("Complete el proceso antes de salir");
            }
            else
            {
                this.Close();
            }
        }
        private void btn_Agregar_Proveedor_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(out string empresa, out long telefono, out string email, out string direccion)) return;  // TODO: Validar los campos antes de agregar
            try
            {
                Logica_Proveedor.AgregarDatos(empresa, telefono, email, direccion);  // TODO: Llamar al método para agregar el proveedor
                CargarProveedores(); 
                LimpiarCampos();     
                MostrarInfo("Proveedor agregado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar el proveedor", ex);  
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (Haycambios())  // TODO: Verificar si hay cambios en los campos antes de limpiar
            {
                LimpiarCampos();  // TODO: Limpiar los campos si hay cambios
            }
            else
            {
                LimpiarCampos();  // TODO: Limpiar los campos si no hay cambios
            }
        }

        private void btn_Eliminar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idProveedor)) return;  // TODO: Verificar si se ha seleccionado una fila válida

            string nombre = dgv_Proveedor.CurrentRow.Cells["Empresa"].Value?.ToString() ?? "proveedor";  // TODO: Obtener el nombre del proveedor

            if (Confirmar($"¿Desea eliminar el proveedor '{nombre}' (ID: {idProveedor})?"))  // TODO: Confirmar la eliminación
            {
                try
                {
                    Logica_Proveedor.EliminarDatos(idProveedor);  
                    CargarProveedores();  
                    LimpiarCampos();     
                    MostrarInfo("Proveedor eliminado correctamente.");  
                }
                catch (Exception ex)
                {
                    MostrarError("Error al eliminar el proveedor", ex);  
                }
            }
        }

        private void btn_Editar_Producto_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int IdProveedor)) return;  // TODO: Verificar si se ha seleccionado un proveedor

            if (!ValidarCampos(out string empresa, out long telefono, out string email, out string direccion)) return;  // TODO: Validar los campos antes de editar

            if (Confirmar($"¿Desea guardar los cambios para el proveedor ID: {IdProveedor}?"))  // TODO: Confirmar la edición
            {
                try
                {
                    Logica_Proveedor.EditarProveedor(empresa, telefono, email, direccion, IdProveedor);  // TODO: Editar los datos del proveedor
                    CargarProveedores();  
                    LimpiarCampos();     
                    MostrarInfo("Proveedor editado correctamente.");  // TODO: Mostrar mensaje de éxito
                }
                catch (Exception ex)
                {
                    MostrarError("Error al editar el proveedor", ex);  // TODO: Mostrar mensaje de error si ocurre una excepción
                }
            }
        }

        //TODO: Métodos Usados ------------------------------------------------------------------------------------------------------

        private bool Haycambios()
        {
            return !string.IsNullOrEmpty(txt_Empresa.Text) || !string.IsNullOrEmpty(txt_Telefono.Text)
                   || !string.IsNullOrEmpty(txt_Email.Text) || !string.IsNullOrEmpty(txt_Direccion.Text);  // TODO: Verificar si hay cambios en los campos del formulario
        }

        private bool FilaSeleccionada(out int id)
        {
            id = -1;
            if (dgv_Proveedor.CurrentRow?.Cells["IdProveedor"].Value == null ||
                !int.TryParse(dgv_Proveedor.CurrentRow.Cells["IdProveedor"].Value.ToString(), out id))
            {
                MostrarAdvertencia("Seleccione un proveedor válido de la lista.");  // TODO: Advertir si no se selecciona un proveedor válido
                return false;
            }
            return true;
        }

        private bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;  // TODO: Confirmar una acción con el usuario
        }

        private bool CorreoDuplicado(string email)
        {
            DataTable correos = Logica_Proveedor.ObtenerCorreos();  // TODO: Obtener los correos de los proveedores
            return correos.AsEnumerable().Any(row =>
                string.Equals(row["Email"].ToString(), email, StringComparison.OrdinalIgnoreCase));  // TODO: Verificar si el correo ya está registrado
        }

        //TODO: Advertencias, Errores e Informaciones -------------------------------------------------------------------------------

        private void MostrarInfo(string mensaje)
        {
            MessageBox.Show(mensaje, "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);  // TODO: Mostrar mensaje de información
        }

        private void MostrarAdvertencia(string mensaje)
        {
            MessageBox.Show(mensaje, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);  // TODO: Mostrar mensaje de advertencia
        }

        private void MostrarError(string mensaje, Exception ex)
        {
            MessageBox.Show($"{mensaje}: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);  // TODO: Mostrar mensaje de error
        }
    }
}
