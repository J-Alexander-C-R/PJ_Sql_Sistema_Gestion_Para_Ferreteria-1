using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Negocios
{
   public class CN_Interfaces
    {

        //TODO: Interfaz para editar Productos
        public interface IEditarProducto
        {
            void EditarDatos(string nombre, double precio, int stock, int idCategoria, int idProveedor, int idProducto);
        }
    }

    //TODO: Interfaz para editar categorías
    public interface IEditarCategoria
    {
        void EditarCategoria(string categoria, int idCategoria);
    }

    //TODO: Interfaz para editar proveedores
    public interface IEditarProveedor
    {
        void EditarProveedor(string empresa, long telefono, string email, string direccion, int idProveedor);
    }
}
