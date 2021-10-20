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
    public partial class main_form : Form
    {
        private List<Usuario> todosUsuarios = new List<Usuario>();
        public main_form()
        {
            InitializeComponent();
        }

        private void bt_regUsu_Click(object sender, EventArgs e)
        {
            RegistrarUsuarioForm f2 = new RegistrarUsuarioForm();
            f2.Ordenes(todosUsuarios);
            cargarFormulario(f2);
        }

        private void bt_compBill_Click(object sender, EventArgs e)
        {
            ComprarBilleteForm f3 = new ComprarBilleteForm();
            f3.Ordenes(todosUsuarios);
            cargarFormulario(f3);
        }

        private void bt_compPlaz_Click(object sender, EventArgs e)
        {
            mostrarReservasForm f = new mostrarReservasForm();
            f.Ordenes(todosUsuarios);
            cargarFormulario(f);
        }

        private void cargarFormulario(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void bt_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
