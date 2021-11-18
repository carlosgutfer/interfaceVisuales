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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString().Equals("Fuentes")) 
            {
                Fuentes f = new Fuentes(this);
                f.ShowDialog();
                
            }else if (sender.ToString().Equals("Salir")) 
            {
                this.Close();
            }
        }

        public void cambiar_texto_main(String dato, int tipo)
        {
            if (tipo == 1)
            {
                tb_main.Font = new Font(dato, tb_main.Font.Size, tb_main.Font.Style);
            }
            else if (tipo == 2)
            {
                tb_main.Font = new Font(tb_main.Font.FontFamily, tb_main.Font.Size, (FontStyle)int.Parse(dato));
            }
            else
            {
                tb_main.Font = new Font(tb_main.Font.FontFamily, float.Parse(dato), tb_main.Font.Style);
            }
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colores f = new Colores(this);
            f.ShowDialog();
        }

        public void cambiar_color(Color c, int cambio) 
        {
            if (cambio == 1)
                tb_main.BackColor = c;
            else
                tb_main.ForeColor = c;
        }
    }
}
