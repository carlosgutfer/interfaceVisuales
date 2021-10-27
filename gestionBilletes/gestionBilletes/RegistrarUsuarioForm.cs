using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionBilletes
{
    public partial class RegistrarUsuarioForm : Form
    {
        private List<Usuario> users = new List<Usuario>();
        public RegistrarUsuarioForm()
        {
            InitializeComponent();
        }

        internal void Ordenes(List<Usuario> user)
        {
            this.users = user;
        }

        private void bt_registrar_Click(object sender, EventArgs e)
        {
            if (validarDNITelefonoEmailUsuario(tb_DNI.Text, tb_telf.Text, tb_email.Text)) 
            {
                users.Add(new Usuario(tb_nombre.Text, tb_DNI.Text, tb_telf.Text, tb_email.Text));
                DialogResult result;
                result = MessageBox.Show("Datos introducidos correctamente");

                this.Close();
            }  
        }

        private bool validarDNITelefonoEmailUsuario(String tb_DNI, String tb_telf, String tb_email)
        {

            String  mensaje;
            Boolean valido;

            valido = true;
            mensaje = "";
            if (!validaDNI(tb_DNI))
                mensaje = "El DNI introducido no es correcto";
            else if (!validarTlf(tb_telf)) 
                mensaje = "El teléfono introducido no es correcto";
            else if (!validarEmail(tb_email)) 
                mensaje = "El correo introducido no es correcto";
            else if (validarUsuario(tb_DNI)) 
                mensaje = "El DNI introducido ya esta registrado";
            if (!mensaje.Equals(""))
            {
                lb_error.Text = mensaje;
                valido = false;
            }   
              return valido;
        }

        private bool validarUsuario(string tb_DNI)
        {
            Boolean encontrado;

            encontrado = false;
            for (int i = 0; i < users.Count && !encontrado; ++i)
                if (users[i].getDNI().Equals(tb_DNI))
                    encontrado = !encontrado;
            return encontrado;
        }

        private bool validarEmail(string tb_email)
        {
            if (tb_email.IndexOf("@") == -1)
                return false;
            return true;
        }

        private bool validarTlf(string tb_telf)
        {
            if (tb_telf.Length != 9)
                return false;
            return true;
        }

        private bool validaDNI(string dni)
        {
            const string cadena = "TRWAGMYFPDXBNJZSQVHLCKE";
            int numero;
            char letra, letra2;
            letra = Convert.ToChar(dni.Substring(dni.Length - 1));
            if ((dni.Length != 9) || !int.TryParse(dni.Substring(0, 8), out numero))
                return false; 
            letra2 = cadena[numero % 23];
            if (letra == letra2)
                return true; 
            else 
                return false; 
        }

        private void bt_borrar_Click(object sender, EventArgs e)
        {
            tb_DNI.Text = "";
            tb_email.Text = "";
            tb_nombre.Text = "";
            tb_telf.Text = "";
        }
    }
}
