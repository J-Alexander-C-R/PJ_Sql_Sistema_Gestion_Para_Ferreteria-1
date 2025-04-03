using System;
using Capa_Datos;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Cliente
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
            SqlCommand cmd = new SqlCommand("Select * From Cliente", Conn);

            //TODO Se crea un adaptador de datos que ejecutará la consulta y llenará el DataTable.
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //TODO Se ejecuta la consulta y los resultados se almacenan en el DataTable.
            da.Fill(tabla);

            //TODO Se cierra la conexión con la base de datos (puede ser innecesario ya que SqlDataAdapter maneja la conexión).
            conexion.CerrarConexion();

            //TODO Se retorna el DataTable con los datos obtenidos.
            return tabla;

        }
    }
}
