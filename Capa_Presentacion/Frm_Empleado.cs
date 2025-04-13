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
        private CN_Empleado Logica_Empleado = new CN_Empleado();

        public Frm_Empleado()
        {
            InitializeComponent();
        }

        private void Frm_Empleado_Load(object sender, EventArgs e)
        {
            CargarEmpleados(); //TODO: Cargar los empleados cuando se carga el formulario
            LimpiarCampos(); //TODO: Limpiar los campos al inicio
            ConfigurarGrid(); //TODO: Configurar el DataGridView para que sea solo lectura y no permita agregar filas
        }

        public void CargarEmpleados()
        {
            try
            {
                dgv_Empleado.DataSource = Logica_Empleado.MostrarDatos(); //TODO: Cargar la lista de empleados
            }
            catch (Exception ex)
            {
                MostrarError("Error al cargar los empleados", ex);
            }
        }

        private void ConfigurarGrid()
        {
            dgv_Empleado.ReadOnly = true; 
            dgv_Empleado.AllowUserToAddRows = false; 
            dgv_Empleado.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dgv_Empleado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; 
        }

        private void dgv_Empleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return; //TODO: Si no se ha seleccionado una fila, no hacer nada

            var row = dgv_Empleado.Rows[e.RowIndex];

            //TODO: Cargar los datos del empleado en los campos de texto
            txt_Nombre.Text = row.Cells["Nombre"].Value?.ToString() ?? "";
            txt_Apellido.Text = row.Cells["Apellido"].Value?.ToString() ?? "";
            txt_Telefono.Text = row.Cells["Telefono"].Value?.ToString() ?? "";
            txt_Cedula.Text = row.Cells["Cedula"].Value?.ToString() ?? "";
            txt_Direccion.Text = row.Cells["Direccion"].Value?.ToString() ?? "";
            txt_Email.Text = row.Cells["Email"].Value?.ToString() ?? "";
            Cmb_Cargo.SelectedItem = row.Cells["Cargo"].Value?.ToString() ?? ""; //TODO: Seleccionamos el cargo
        }

        private void LimpiarCampos()
        {
            
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Telefono.Clear();
            txt_Cedula.Clear();
            txt_Direccion.Clear();
            txt_Email.Clear();
            Cmb_Cargo.SelectedIndex = -1; //TODO: Limpiar la selección del ComboBox
        }

        private bool ValidarCampos(out string nombre, out string apellido, out int telefono, out int cedula, out string direccion, out string email, out string cargo)
        {
            nombre = txt_Nombre.Text.Trim();
            apellido = txt_Apellido.Text.Trim();
            string telefonoTexto = txt_Telefono.Text.Trim();
            telefono = 0;
            cedula = 0;
            direccion = txt_Direccion.Text.Trim();
            email = txt_Email.Text.Trim();
            cargo = Cmb_Cargo.SelectedItem?.ToString(); //TODO: Obtenemos el cargo del ComboBox

            //TODO: Validar que los campos no estén vacíos
            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(apellido) || string.IsNullOrEmpty(telefonoTexto) || string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(cargo))
            {
                MostrarAdvertencia("Por favor, rellene todos los campos.");
                return false;
            }

            //TODO: Validar que el teléfono sea un número válido
            if (!int.TryParse(txt_Telefono.Text.Trim(), out telefono) || telefono <= 0)
            {
                MostrarAdvertencia("Ingrese un número de teléfono válido.");
                return false;
            }

            //TODO: Validar que la cédula sea válida
            if (!int.TryParse(txt_Cedula.Text.Trim(), out cedula) || cedula <= 0)
            {
                MostrarAdvertencia("Ingrese una cédula válida.");
                return false;
            }

            //TODO: Validar que el email sea válido
            if (!email.Contains("@") || !email.Contains("."))
            {
                MostrarAdvertencia("Ingrese una dirección de email válida.");
                return false;
            }

            //TODO: Verificar si el email ya está registrado
            if (EmailDuplicado(email))
            {
                MostrarAdvertencia("Ya existe un empleado con ese correo electrónico.");
                return false;
            }

            //TODO: Verificar si la cédula ya está registrada
            if (CedulaDuplicada(cedula))
            {
                MostrarAdvertencia("Ya existe un empleado con esa cédula.");
                return false;
            }

            if (telefonoTexto.Length <= 8)
            {
                MostrarAdvertencia("El número de teléfono debe tener más de 8 dígitos.");  // TODO: Advertir si el teléfono tiene menos de 8 dígitos
                return false;
            }

            return true;
        }

        //TODO: Método para verificar si el email ya está registrado
        private bool EmailDuplicado(string email)
        {
            DataTable emails = Logica_Empleado.ObtenerEmails();
            return emails.AsEnumerable().Any(row =>
                string.Equals(row["Email"].ToString(), email, StringComparison.OrdinalIgnoreCase)); //TODO: Comparar los emails ignorando mayúsculas/minúsculas
        }

        //TODO: Método para verificar si la cédula ya está registrada
        private bool CedulaDuplicada(int cedula)
        {
            DataTable cedulas = Logica_Empleado.ObtenerCedulas();
            return cedulas.AsEnumerable().Any(row =>
                string.Equals(row["Cedula"].ToString(), cedula.ToString(), StringComparison.OrdinalIgnoreCase)); //TODO: Comparar las cédulas
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

        private void btn_Agregar_Empleado_Click(object sender, EventArgs e)
        {
            //TODO: Validar campos antes de agregar el empleado
            if (!ValidarCampos(out string nombre, out string apellido, out int telefono, out int cedula, out string direccion, out string email, out string cargo)) return;

            try
            {
                Logica_Empleado.AgregarDatos(nombre, apellido, telefono, cedula, direccion, email, cargo); //TODO: Llamada a la lógica de negocio para agregar el empleado
                CargarEmpleados(); //TODO: Recargar la lista de empleados
                LimpiarCampos(); //TODO: Limpiar los campos después de agregar el empleado
                MostrarInfo("Empleado agregado correctamente.");
            }
            catch (Exception ex)
            {
                MostrarError("Error al agregar el empleado", ex);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos(); //TODO: Limpiar los campos cuando se cancela la acción
        }

        private void btn_Eliminar_Empleado_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idEmpleado)) return;

            string nombre = dgv_Empleado.CurrentRow.Cells["Nombre"].Value?.ToString() ?? "empleado";

            //TODO: Confirmar antes de eliminar un empleado
            if (Confirmar($"¿Desea eliminar el empleado '{nombre}' (ID: {idEmpleado})?"))
            {
                try
                {
                    Logica_Empleado.EliminarDatos(idEmpleado); //TODO: Llamada a la lógica de negocio para eliminar el empleado
                    CargarEmpleados(); //TODO: Recargar la lista de empleados
                    LimpiarCampos(); //TODO: Limpiar los campos después de eliminar el empleado
                    MostrarInfo("Empleado eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al eliminar el empleado", ex);
                }
            }
        }

        private void btn_Editar_Empleado_Click(object sender, EventArgs e)
        {
            if (!FilaSeleccionada(out int idEmpleado)) return;

            //TODO: Validar campos antes de editar el empleado
            if (!ValidarCampos(out string nombre, out string apellido, out int telefono, out int cedula, out string direccion, out string email, out string cargo)) return;

            //TODO: Confirmar antes de editar el empleado
            if (Confirmar($"¿Desea guardar los cambios para el empleado ID: {idEmpleado}?"))
            {
                try
                {
                    Logica_Empleado.EditarDatos(idEmpleado, nombre, apellido, telefono, cedula, direccion, email, cargo); //TODO: Llamada a la lógica de negocio para editar el empleado
                    CargarEmpleados(); //TODO: Recargar la lista de empleados
                    LimpiarCampos(); //TODO: Limpiar los campos después de editar el empleado
                    MostrarInfo("Empleado editado correctamente.");
                }
                catch (Exception ex)
                {
                    MostrarError("Error al editar el empleado", ex);
                }
            }
        }

        //TODO: Método para verificar si se ha seleccionado una fila
        private bool FilaSeleccionada(out int id)
        {
            id = -1;
            if (dgv_Empleado.CurrentRow?.Cells["IdEmpleado"].Value == null ||
                !int.TryParse(dgv_Empleado.CurrentRow.Cells["IdEmpleado"].Value.ToString(), out id))
            {
                MostrarAdvertencia("Seleccione un empleado válido de la lista.");
                return false;
            }
            return true;
        }
        
        private bool HayCambios()
        {
            return !string.IsNullOrWhiteSpace(txt_Nombre.Text) || !string.IsNullOrWhiteSpace(txt_Apellido.Text) ||
                   !string.IsNullOrWhiteSpace(txt_Email.Text);
        }
        //TODO: Método para confirmar una acción
        private bool Confirmar(string pregunta)
        {
            return MessageBox.Show(pregunta, "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        //TODO: Métodos para mostrar mensajes
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
