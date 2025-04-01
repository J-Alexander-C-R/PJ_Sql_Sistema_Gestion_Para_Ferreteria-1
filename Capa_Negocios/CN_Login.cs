using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Login
    {
        private CD_Conexion conexion = new CD_Conexion();
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            SqlConnection conn = conexion.AbrirConexion(); //TODO Esto Abre la conexión con el método

            string query = "SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);

            int count = (int)cmd.ExecuteScalar(); //TODO Esto de aquí Ejecuta la consulta

            conexion.CerrarConexion(); //TODO Esto Cierra la conexión con tu método

            return count > 0; //TODO Si encuentra coincidencias, retorna true
        }
    }
}
