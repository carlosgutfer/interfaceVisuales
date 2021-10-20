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
    public partial class ComprarBilleteForm : Form
    {
        private List<Usuario> users = new List<Usuario>();
        private Usuario usuarioElegido;
        public ComprarBilleteForm()
        {
            InitializeComponent();
        }

        private void ComprarBilleteForm_Load(object sender, EventArgs e)
        {

        }

        internal void Ordenes(List<Usuario> user)
        {
            this.users = user;
        }
        private void cargarPlazasLibre()
        {
            String mensaje;

            mensaje = "";
            for (int i = 1; i <= 65; ++i)
            {
                for (int j = 0; j < users.Count; ++j)
                {
                    if (users[j].getNumPlaza() == i)
                        mensaje += "  ";
                    else if(j + 1 == users.Count) 
                    {
                        if (i < 9)
                            mensaje += " " +i + " ";
                        else
                            mensaje += i + " ";
                    }                        
                }
                if (i % 2 == 0 && i % 4 != 0)
                    mensaje += "-";
                else if (i % 4 == 0)
                    mensaje += "\n";
            }
            lb_asientos.Text = mensaje;
            lb_asientos.AutoSize = true;
            bt_elegir.Visible = true;
            tb_numAsiento.Visible = true;
            lb_asiento.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comprobarUsuario(tb_DNI.Text, users))
                cargarPlazasLibre();
            else
                lb_error.Text = "Usuario no encontrado, regístrelo para continuar";
        }

        private bool comprobarUsuario(String tb, List<Usuario> users)
        {
            Boolean encontrado;

            encontrado = false;
            for(int i = 0; i < users.Count && !encontrado; ++i) 
            {
                if (users[i].getDNI().Equals(tb))
                {
                    encontrado = true;
                    usuarioElegido = users[i];
                }
            }
            return encontrado;
        }

        private void bt_elegir_Click(object sender, EventArgs e)
        {
            int numAsiento;
            String mensaje;
            DialogResult result;


            mensaje = "El asiento se ha seleccionado correctamente";
            numAsiento = int.Parse(tb_numAsiento.Text);
            if (numAsiento > 0 && numAsiento < 66)
            {
                if (!comprobarAsientoLibre(numAsiento, users))
                {
                    usuarioElegido.setNumPlaza(numAsiento);
                    result = MessageBox.Show(mensaje);
                    this.Close();
                }
                else
                    mensaje = "El asiento ya está ocupado";
            }
            else
                mensaje = "Debe elegir un asiento entre los que  están libres";
            lb_error.Text = mensaje;
        }

        private bool comprobarAsientoLibre(int numAsiento, List<Usuario> users)
        {
            bool encontrado;

            encontrado = false;
            for (int i = 0; i < users.Count && !encontrado; ++i)
                if (users[i].getNumPlaza() == numAsiento)
                    encontrado = true;
            return encontrado;       
        }
    }
}
