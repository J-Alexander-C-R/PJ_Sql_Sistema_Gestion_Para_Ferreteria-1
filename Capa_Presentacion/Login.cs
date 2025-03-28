namespace Capa_Presentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void ckb_Mostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_Mostrar.Checked == true)
            {
               if(txt_Contraseña.PasswordChar == '*')
                {
                    txt_Contraseña.PasswordChar = '\0';
                }
            }
           else
            {
                txt_Contraseña.PasswordChar = '*';
            }

        }
    }
}
