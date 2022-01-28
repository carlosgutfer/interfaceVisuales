using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Instituto
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void listadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem eleccion = (ToolStripMenuItem)sender;
            String nombre = eleccion.Name;
            if (nombre.Equals("TS_alta"))
            {
                Alta f = new Alta();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else if (nombre.Equals(TS_1dama.Name) || nombre.Equals(TS_1damb.Name) || nombre.Equals(TS_2dama.Name)||nombre.Equals(TS_2damb.Name))
            {
                Listado l = new Listado(eleccion.Text);
                this.Hide();
                l.ShowDialog();
                this.Show();
            }
            else if (nombre.Equals("TS_baja")) 
            {
                Baja b = new Baja();
                this.Hide();
                b.ShowDialog();
                this.Show();
            }
        }

        private void ºDAMAToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem eleccion = (ToolStripMenuItem)sender;
            String nombre = eleccion.Name;
            if (nombre.Equals(TS_1damanotas.Name) || nombre.Equals(TS_1dambnotas.Name) || nombre.Equals(TS_2damanotas.Name) || nombre.Equals(TS_2dambnotas.Name))
            {
                PonerNotas pn = new PonerNotas(eleccion.Text);
                this.Hide();
                pn.ShowDialog();
                this.Show();
            }
        }
    }
}
