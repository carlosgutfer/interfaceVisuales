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
    public partial class mostrarReservasForm : Form
    {
        private List<Usuario> users = new List<Usuario>();

        public mostrarReservasForm()
        {
            InitializeComponent();
        }

        private void Plazas_vendidas_Load(object sender, EventArgs e)
        {

            String DNI;
            String numPlaza;

            DNI = "";
            numPlaza = "";
            for(int i = 0; i < users.Count; ++i) 
            { 
                if(users[i].getNumPlaza() != 0) 
                {
                    DNI += users[i].getDNI() + "\n";
                    numPlaza += users[i].getNumPlaza().ToString() + "\n";

                }
            }
            lb_nombre.Text = DNI;
            lb_numPlaza.Text = numPlaza;
        }
        internal void Ordenes(List<Usuario> user)
        {
            this.users = user;
        }
    }
}
