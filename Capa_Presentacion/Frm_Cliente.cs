using System;
using Capa_Negocios;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion
{
    public partial class Frm_Cliente : Form
    {
        private CN_Cliente Logica_Cliente = new CN_Cliente();
        public Frm_Cliente()
        {
            InitializeComponent();
            //TODO Se asigna como origen de datos del DataGridView (dgv_Cliente) el resultado del método MostrarDatos().
            //TODO El método MostrarDatos(), perteneciente a la capa lógica (Logica_Cliente), devuelve un DataTable con los datos de la tabla Cliente desde la base de datos.
            //TODO Al establecer ese DataTable como DataSource, el DataGridView (dgv_Cliente) se llena automáticamente con los registros de los clientes.
            //TODO Esto permite mostrar en pantalla todos los datos de los clientes recuperados desde la base de datos.
            dgv_Cliente.DataSource = Logica_Cliente.MostrarDatos();
        }
    }
}
