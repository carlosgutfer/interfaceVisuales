using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class form_buscar : Form
    {
        private Main m;

        public form_buscar(Main main)
        {
            InitializeComponent();
            this.m = main;
        }

        private void bt_buscarSiguiente_Click(object sender, EventArgs e)
        {
            m.buscar(textBox1.Text);
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
