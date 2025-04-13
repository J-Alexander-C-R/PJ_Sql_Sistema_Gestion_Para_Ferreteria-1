using Capa_Datos;
using Microsoft.Data.SqlClient;

namespace Capa_Negocios
{
    public class CN_Login : CN_Base
    {
    
        public bool ValidarUsuario(string usuario, string contraseña)
        {
            //TODO: Abrimos la conexión a la base de datos usando el método heredado
            SqlConnection Conn = AbrirConexion();

            //TODO: Preparamos la consulta SQL para verificar si el usuario y contraseña existen
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Login WHERE Usuario = @Usuario AND Contraseña = @Contraseña", Conn);

            //TODO: Asignamos los valores de entrada a los parámetros del comando
            cmd.Parameters.AddWithValue("@Usuario", usuario);
            cmd.Parameters.AddWithValue("@Contraseña", contraseña);

            //TODO: Ejecutamos la consulta y obtenemos el número de coincidencias
            int count = (int)cmd.ExecuteScalar();

            //TODO: Cerramos la conexión a la base de datos
            CerrarConexion();

            //TODO: Retorna true si hay coincidencias (usuario válido), de lo contrario, false
            return count > 0;
        }
    }
}
