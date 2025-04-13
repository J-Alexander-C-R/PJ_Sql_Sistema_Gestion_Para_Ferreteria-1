using System;
using Capa_Datos;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Cliente : CN_Base
    {
        //TODO: Metodo para mostrar datos
        public DataTable MostrarDatos()
        {
            DataTable tabla = new DataTable();
            SqlConnection Conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cliente", Conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            conexion.CerrarConexion();
            return tabla;
        }

        //TODO: Metodo para agregar datos
        public void AgregarDatos(string nombre, string apellido, long telefono, string email, string direccion)
        {
            SqlConnection Conn = AbrirConexion();
            SqlCommand Cmd = new SqlCommand("INSERT INTO Cliente (Nombre, Apellido, Telefono, Email, Direccion) VALUES (@Nombre, @Apellido, @Telefono, @Email, @Direccion)", Conn);
            Cmd.Parameters.AddWithValue("@Nombre", nombre);
            Cmd.Parameters.AddWithValue("@Apellido", apellido);
            Cmd.Parameters.AddWithValue("@Telefono", telefono);
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@Direccion", direccion);
            Cmd.ExecuteNonQuery();
            CerrarConexion();
        }


        //TODO: Metodo para eliminar datos
        public void EliminarDatos(int idCliente)
        {
            SqlConnection Conn = AbrirConexion();
            SqlCommand Cmd = new SqlCommand("DELETE FROM Cliente WHERE IdCliente = @IDCliente", Conn);
            Cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            Cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void EditarDatos(int idCliente, string nombre, string apellido, long telefono, string email, string direccion)
        {
            //TODO: Abrir conexión a la base de datos
            SqlConnection Conn = AbrirConexion();

            //TODO: Crear el comando SQL con los parámetros
            SqlCommand Cmd = new SqlCommand(
                "UPDATE Cliente SET Nombre = @Nombre, Apellido = @Apellido, Telefono = @Telefono, Email = @Email, Direccion = @Direccion WHERE IdCliente = @IdCliente",
                Conn
            );

            //TODO: Asignar valores a los parámetros
            Cmd.Parameters.AddWithValue("@IdCliente", idCliente);
            Cmd.Parameters.AddWithValue("@Nombre", nombre);
            Cmd.Parameters.AddWithValue("@Apellido", apellido);
            Cmd.Parameters.AddWithValue("@Telefono", telefono);
            Cmd.Parameters.AddWithValue("@Email", email);
            Cmd.Parameters.AddWithValue("@Direccion", direccion);

            //TODO: Ejecutar comando
            Cmd.ExecuteNonQuery();

            //TODO: Cerrar conexión
            CerrarConexion();
        }

        public DataTable ObtenerCorreos()
        {
            //TODO: Abrir conexión
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear comando SQL para seleccionar los correos
            SqlCommand cmd = new SqlCommand("SELECT Email FROM Cliente", Conn);
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
