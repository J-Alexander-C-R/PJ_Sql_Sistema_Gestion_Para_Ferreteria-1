using System;
using Capa_Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Data;

namespace Capa_Negocios
{
    public class CN_Categoria : CN_Base, IEditarCategoria
    {


        //TODO: Método para mostrar todos los datos de la tabla Categoria_Producto
        public DataTable MostrarDatos()
        {
            //TODO: Crear un objeto DataTable para almacenar los datos recuperados de la base de datos
            DataTable tabla = new DataTable();
            //TODO: Abrir la conexión con la base de datos
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear un comando SQL para seleccionar todos los registros de la tabla Categoria_Producto
            SqlCommand cmd = new SqlCommand("SELECT IdCategoria, Categoria FROM Categoria_Producto", Conn);
            //TODO: Crear un adaptador de datos que ejecutará la consulta y llenará el DataTable
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //TODO: Ejecutar la consulta y llenar el DataTable
            da.Fill(tabla);
            //TODO: Cerrar la conexión con la base de datos
            CerrarConexion();
            //TODO: Retornar el DataTable con los datos obtenidos
            return tabla;
        }

        //TODO: Método para mostrar solo IdCategoria y Categoria (para uso en ComboBox u otros controles)
        public DataTable MostrarCategorias()
        {
            //TODO: Abrir la conexión con la base de datos
            SqlConnection conn = AbrirConexion();
            //TODO: Crear un objeto DataTable para almacenar los resultados
            DataTable tabla = new DataTable();
            //TODO: Crear un comando SQL para obtener solo IdCategoria y Categoria
            SqlCommand cmd = new SqlCommand("SELECT IdCategoria, Categoria FROM Categoria_Producto", conn);
            //TODO: Crear adaptador y llenar la tabla
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tabla);
            //TODO: Cerrar la conexión
            CerrarConexion();
            //TODO: Retornar la tabla con los resultados
            return tabla;
        }

        //TODO: Método para agregar una nueva categoría
        public void AgregarDatos(string categoria)
        {
            //TODO: Abrir la conexión con la base de datos
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear un comando SQL para insertar una nueva categoría
            SqlCommand cmd = new SqlCommand("INSERT INTO Categoria_Producto (Categoria) VALUES (@Categoria)", Conn);
            //TODO: Asignar el valor del parámetro recibido
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            //TODO: Ejecutar la consulta SQL
            cmd.ExecuteNonQuery();
            //TODO: Cerrar la conexión
            CerrarConexion();
        }

        //TODO: Método para eliminar una categoría por ID
        public void EliminarDatos(int id_Categoria)
        {
            //TODO: Abrir la conexión con la base de datos
            SqlConnection Conn = AbrirConexion();
            //TODO: Crear la consulta SQL para eliminar una categoría
            SqlCommand Cmd = new SqlCommand("DELETE FROM Categoria_Producto WHERE IdCategoria = @IdCategoria", Conn);
            //TODO: Asignar el parámetro con el ID de la categoría
            Cmd.Parameters.AddWithValue("@IdCategoria", id_Categoria);
            //TODO: Ejecutar la consulta
            Cmd.ExecuteNonQuery();
            //TODO: Cerrar la conexión
            CerrarConexion();
        }

        public void EditarCategoria(string categoria, int idCategoria)
        {
            //TODO: Abrimos la conexión a la base de datos
            SqlConnection Conn = AbrirConexion();
            //TODO: Creamos el comando SQL para actualizar la categoría
            SqlCommand cmd = new SqlCommand("UPDATE Categoria_Producto SET Categoria = @Categoria WHERE IdCategoria = @IdCategoria", Conn);
            //TODO: Asignamos los parámetros con los valores recibidos
            cmd.Parameters.AddWithValue("@Categoria", categoria);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            //TODO: Ejecutamos el comando
            cmd.ExecuteNonQuery();
            //TODO: Cerramos la conexión a la base de datos
            CerrarConexion();
        }
    }
}
