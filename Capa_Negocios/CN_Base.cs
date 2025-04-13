using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Base
    {
        //TODO: Instanciamos un objeto de la clase CD_Conexion para poder abrir/cerrar conexiones.    
        public CD_Conexion conexion = new CD_Conexion();

        //TODO: Método para abrir la conexión a la base de datos a través del objeto conexion.
        public SqlConnection AbrirConexion()
        {
            return conexion.AbrirConexion();
        }

        //TODO: Método para cerrar la conexión a la base de datos a través del objeto conexion.
        public void CerrarConexion()
        {
            conexion.CerrarConexion();
        }
    }
}
