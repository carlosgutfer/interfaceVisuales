using System;
using System.Windows.Forms;

namespace ClaseMala3
{
    public partial class Form1 : Form
    {
        private String[,] usuarioContraseña = { {"USRJ", "1234"} };
        private int count = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //3 intentos
           
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {

            if (txt_login.Text.Equals(usuarioContraseña.GetValue(0, 0))
                   && txt_contraseña.Text.Equals( usuarioContraseña.GetValue(0, 1)))
                lbl_mostrar.Text = "Hola" + usuarioContraseña.GetValue(0, 0) + " tu contraseña es "
                        + usuarioContraseña.GetValue(0, 1);
            else 
            {
                count++;
                txt_contraseña.Text = "";
                txt_login.Text = "";
            }
            if (count == 3)
                lbl_mostrar.Text = "Has superado el intento máximo para logearte. ";
        }
    }
}
