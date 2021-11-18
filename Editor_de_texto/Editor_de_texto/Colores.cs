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
    public partial class Colores : Form
    {
        Main f;
        public Colores(Main main)
        {
            InitializeComponent();
            this.f = main;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (rb_colorFondo.Checked)
                {
                    tb_colores.BackColor = Color.FromArgb(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    f.cambiar_color(tb_colores.BackColor, 1);
                }
                else if (rb_colorFuente.Checked)
                {
                    tb_colores.ForeColor = Color.FromArgb(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text));
                    f.cambiar_color(tb_colores.ForeColor, 2);
                }           
            }
            catch (Exception) { }
        }
    }
}
