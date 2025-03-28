using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Datos
{
    public class CD_Conexion
    {
        private SqlConnection Conn = new SqlConnection("Server=.; Database=Sistema_De_Gestion_Para_Ferreterias; Integrated Security=true");

        public SqlConnection AbrirConexion()
        {
            if (Conn.State == ConnectionState.Closed)
                Conn.Open();
            return Conn;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conn.State == ConnectionState.Open)
                Conn.Close();
            return Conn;
        }

    }
}
