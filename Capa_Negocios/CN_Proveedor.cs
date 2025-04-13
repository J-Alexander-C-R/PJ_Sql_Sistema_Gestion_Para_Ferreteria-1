using System;
using Capa_Negocios;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Negocios
{
    public class CN_Proveedor : CN_Base, IEditarProveedor
    {

        //TODO: Método para mostrar todos los datos de la tabla Proveedor
        public DataTable MostrarDatos()
        {
            //TODO: Crear un DataTable para almacenar los datos
            DataTable tabla = new DataTable();
            //TODO: Abrir conexión con la base de datos
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL para obtener todos los proveedores
            SqlCommand cmd = new SqlCommand("SELECT IdProveedor, Empresa, Telefono, Email, Direccion FROM Proveedor", Conn);
            //TODO: Crear adaptador para llenar el DataTable con los resultados de la consulta
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //TODO: Llenar el DataTable
            da.Fill(tabla);
            //TODO: Cerrar la conexión
            CerrarConexion();
            //TODO: Retornar la tabla llena
            return tabla;
        }

        //TODO: Método para mostrar solo ID y Empresa (útil para combobox)
        public DataTable MostrarProveedores()
        {
            //TODO: Abrir conexión con la base de datos
            SqlConnection conn = AbrirConexion();
            //TODO: Crear un DataTable para almacenar resultados
            DataTable tabla = new DataTable();
            //TODO: Crear el comando SQL para obtener proveedores
            SqlCommand cmd = new SqlCommand("SELECT IdProveedor, Empresa FROM Proveedor", conn);
            //TODO: Crear adaptador y llenar la tabla
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            //TODO: Cerrar conexión
            CerrarConexion();
            //TODO: Retornar la tabla
            return tabla;
        }

        //TODO: Método para agregar un nuevo proveedor
        public void AgregarDatos(string empresa, long telefono, string email, string direccion)
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear el comando SQL con parámetros
            SqlCommand cmd = new SqlCommand("INSERT INTO Proveedor (Empresa, Telefono, Email, Direccion) VALUES (@Empresa, @Telefono, @Email, @Direccion)", Conn);
            //TODO: Asignar valores a los parámetros
            cmd.Parameters.AddWithValue("@Empresa", empresa);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            //TODO: Ejecutar la consulta
            cmd.ExecuteNonQuery();
            //TODO: Cerrar conexión
            CerrarConexion();
        }

        //TODO: Método para eliminar proveedor por ID
        public void EliminarDatos(int idProveedor)
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL con parámetro
            SqlCommand cmd = new SqlCommand("DELETE FROM Proveedor WHERE IdProveedor = @IdProveedor", Conn);
            //TODO: Asignar ID al parámetro
            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
            //TODO: Ejecutar la consulta
            cmd.ExecuteNonQuery();
            //TODO: Cerrar conexión
            CerrarConexion();
        }

        public void EditarProveedor(string empresa, long telefono, string email, string direccion, int idProveedor)
        {
            SqlConnection connection = AbrirConexion();
            SqlCommand cmd = new SqlCommand("UPDATE Proveedor SET Empresa = @Empresa, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE IdProveedor = @IdProveedor", connection);
            cmd.Parameters.AddWithValue("@Empresa", empresa);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        //TODO: Método para obtener todos los correos electrónicos de los proveedores
        public DataTable ObtenerCorreos()
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL para seleccionar los correos
            SqlCommand cmd = new SqlCommand("SELECT Email FROM Proveedor", Conn);
            //TODO: Crear adaptador y DataTable para llenar los datos
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tabla = new DataTable();
            //TODO: Llenar la tabla
            da.Fill(tabla);
            //TODO: Cerrar conexión
            CerrarConexion();
            //TODO: Retornar la tabla con los correos
            return tabla;
        }
    }
}