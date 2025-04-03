﻿using Capa_Datos;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Capa_Negocios
{
    public class CN_Producto
    {
        //TODO Se crea una instancia de la clase CD_Conexion para gestionar la conexión con la base de datos.
        private CD_Conexion conexion = new CD_Conexion();

        public DataTable MostrarDatos()
        {
            //TODO Se crea un objeto DataTable para almacenar los datos recuperados de la base de datos.
            DataTable tabla = new DataTable();

            //TODO Se abre la conexión a la base de datos.
            SqlConnection Conn = conexion.AbrirConexion();

            //TODO Se crea un comando SQL para seleccionar todos los registros de la tabla Cliente.
            SqlCommand cmd = new SqlCommand("Select * From Producto", Conn);

            //TODO Se crea un adaptador de datos que ejecutará la consulta y llenará el DataTable.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //TODO Se ejecuta la consulta y los resultados se almacenan en el DataTable.
            da.Fill(tabla);

            //TODO Se cierra la conexión con la base de datos (puede ser innecesario ya que SqlDataAdapter maneja la conexión).
            conexion.CerrarConexion();

            //TODO Se retorna el DataTable con los datos obtenidos.
            return tabla;

        }

        public void AgregarDatos(string producto, double precio, int stock, int idCategoria, int idProveedor)
        {
            SqlConnection Conn = conexion.AbrirConexion();
            SqlCommand cmd = new SqlCommand("INSERT INTO Producto (Nombre_Producto, Precio, Stock, Id_Proveedor, Id_Categoria) VALUES (@Nombre, @Precio, @Stock, @IdProveedor, @IdCategoria)", Conn);
            cmd.Parameters.AddWithValue("@Nombre", producto);
            cmd.Parameters.AddWithValue("@Precio", precio);
            cmd.Parameters.AddWithValue("@Stock", stock);
            cmd.Parameters.AddWithValue("@IdProveedor", idProveedor);
            cmd.Parameters.AddWithValue("@IdCategoria", idCategoria);

            cmd.ExecuteNonQuery();
            conexion.CerrarConexion();
        }
    }
}
