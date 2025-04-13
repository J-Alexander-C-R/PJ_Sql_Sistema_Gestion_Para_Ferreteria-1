using Microsoft.Data.SqlClient;
using System;
using Capa_Datos;
using System.Data;

namespace Capa_Negocios
{
    public class CN_Empleado : CN_Base
    {
        //TODO: Metodo para mostrar datos en el datagridview
        public DataTable MostrarDatos()
        {
            DataTable tabla = new DataTable();
            SqlConnection Conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Empleado", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        //TODO: Metodo para agregar datos
        public void AgregarDatos(string nombre, string apellido, int telefono, int cedula, string direccion, string email, string cargo)
        {
            SqlConnection Conn = AbrirConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO Empleado (Nombre, Apellido, Telefono, Cedula, Direccion, Email, Cargo) VALUES (@Nombre, @Apellido, @Telefono, @Cedula, @Direccion, @Email, @Cargo)", Conn);
            cmd.Parameters.AddWithValue("@Nombre", nombre);
            cmd.Parameters.AddWithValue("@Apellido", apellido);
            cmd.Parameters.AddWithValue("@Telefono", telefono);
            cmd.Parameters.AddWithValue("@Cedula", cedula);
            cmd.Parameters.AddWithValue("@Direccion", direccion);
            cmd.Parameters.AddWithValue("@Email", email);
            cmd.Parameters.AddWithValue("@Cargo", cargo);
            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        //Metodo para eliminar datos
        public void EliminarDatos(int idEmpleado)
        {
            SqlConnection Conn = AbrirConexion();
            SqlCommand Cmd = new SqlCommand("DELETE FROM Empleado WHERE IdEmpleado = @IDEmpleado", Conn);
            Cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            Cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        //Metodo para editar datos
        public void EditarDatos(int idEmpleado, string nombre, string apellido, long telefono, long cedula, string direccion, string email, string cargo)
        {
            SqlConnection Conn = AbrirConexion();
            SqlCommand Cmd = new SqlCommand(
                "UPDATE Empleado SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Cedula = @Cedula, Direccion = @Direccion, Email = @Email, Cargo = @Cargo WHERE IdEmpleado = @IdEmpleado",
                Conn
            );
            Cmd.Parameters.AddWithValue("@IdEmpleado", idEmpleado);
            Cmd.Parameters.AddWithValue("@Nombre", nombre);
            Cmd.Parameters.AddWithValue("@Apellido", apellido);
            Cmd.Parameters.AddWithValue("@Telefono", telefono);
            Cmd.Parameters.AddWithValue("@Cedula", cedula);
            Cmd.Parameters.AddWithValue("@Direccion", direccion);
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@Cargo", cargo);
            Cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public DataTable ObtenerEmails()
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL para seleccionar los correos
            SqlCommand cmd = new SqlCommand("SELECT Email FROM Empleado", Conn);
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

        public DataTable ObtenerCedulas()
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL para seleccionar los correos
            SqlCommand cmd = new SqlCommand("SELECT Cedula FROM Empleado", Conn);
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
