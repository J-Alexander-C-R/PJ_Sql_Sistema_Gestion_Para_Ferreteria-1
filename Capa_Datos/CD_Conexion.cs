using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        // TODO: Instanciamos un objeto SqlConnection con la cadena de conexión a la base de datos
        private SqlConnection Conn = new SqlConnection("Server=.; Database=sdg_Ferreteria; Integrated Security=true; TrustServerCertificate=True");

        // TODO: Método para abrir la conexión a la base de datos si esta cerrada.
        public SqlConnection AbrirConexion()
        {
            // TODO: Verifica si la conexión está cerrada antes de abrirla, para evitar errores.
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();  
            return Conn;
        }

        // TODO: Método para cerrar la conexión a la base de datos si está abierta.
        public SqlConnection CerrarConexion()
        {
            // TODO Verifica si la conexión está abierta antes de cerrarla, para evitar errores
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }

    }
}
