using Capa_Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Capa_Negocios.CN_Interfaces;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Negocios
{
    public class CN_Producto : CN_Base, IEditarProducto
    {
        
        public DataTable MostrarDatos()
        {
            // TODO: Se crea una nueva tabla para almacenar los datos de productos obtenidos.
            DataTable tabla = new DataTable();
            // TODO: Se abre la conexión a la base de datos utilizando el método heredado de CN_Base.
            SqlConnection Conn = AbrirConexion();
            // TODO: Se define la consulta SQL para seleccionar todos los campos deseados desde la tabla Producto (consulta en una sola línea).
            SqlCommand cmd = new SqlCommand("SELECT IdProducto, NombreProducto, Precio, Stock, IdProveedor, IdCategoria FROM Producto;", Conn);
            // TODO: Se utiliza un adaptador para llenar la tabla con los resultados de la consulta.
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // TODO: Se llena la tabla con los datos.
            da.Fill(tabla);
            // TODO: Se cierra la conexión luego de completar la operación.
            CerrarConexion();
            // TODO: Se retorna el resultado al llamador.
            return tabla;

        }

        public void AgregarDatos(string producto, double precio, int stock, int idCategoria, int idproveedor)
        {
            // TODO: Se abre la conexión con la base de datos.
            SqlConnection Conn = AbrirConexion();
            // TODO: Se crea la consulta SQL para insertar un nuevo producto (en una sola línea).
            SqlCommand cmd = new SqlCommand("INSERT INTO Producto (NombreProducto, Precio, Stock, IdProveedor, IdCategoria) VALUES (@NombreProducto, @Precio, @Stock, @IdProveedor, @IdCategoria);", Conn);
            // TODO: Se asignan los valores recibidos por parámetro a los parámetros SQL.
            cmd.Parameters.AddWithValue("@NombreProducto", producto);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@IdProveedor", idproveedor);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            // TODO: Se ejecuta el comando para insertar los datos.
            cmd.ExecuteNonQuery();
            // TODO: Se cierra la conexión después de la inserción.
            CerrarConexion();
        }

        public void EditarDatos(string nombre, double precio, int stock, int idCategoria, int idProveedor, int idProducto)
        {
            // TODO: Se abre la conexión a la base de datos.
            SqlConnection Conn = AbrirConexion();
            // TODO: Se crea la consulta SQL para actualizar un producto existente (consulta en una sola línea).
            SqlCommand cmd = new SqlCommand("UPDATE Producto SET NombreProducto = @NombreProducto, Precio = @Precio, Stock = @Stock, IdCategoria = @IdCategoria, IdProveedor = @IdProveedor WHERE IdProducto = @IdProducto;", Conn);
            // TODO: Se asignan los valores recibidos por parámetro a los parámetros del comando SQL.
            cmd.Parameters.AddWithValue("@NombreProducto", nombre);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);
            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
            cmd.Parameters.AddWithValue("@IdProducto", idProducto);
            // TODO: Se ejecuta el comando SQL para actualizar los datos del producto.
            cmd.ExecuteNonQuery();
            // TODO: Se cierra la conexión después de la operación.
            CerrarConexion();
        }

        public void EliminarDatos(int idProducto)
        {
            // TODO: Se abre la conexión a la base de datos.
            SqlConnection Conn = AbrirConexion();
            // TODO: Se define el comando SQL para eliminar un producto por su ID (consulta en una sola línea).
            SqlCommand Cmd = new SqlCommand("DELETE FROM Producto WHERE IdProducto = @IdProducto;", Conn);
            // TODO: Se asigna el ID del producto a eliminar al parámetro del comando SQL.
            Cmd.Parameters.AddWithValue("@IdProducto", idProducto);
            // TODO: Se ejecuta el comando SQL para eliminar el producto.
            Cmd.ExecuteNonQuery();
            // TODO: Se cierra la conexión a la base de datos después de eliminar el producto.
            CerrarConexion();
        }

        
    }
}
