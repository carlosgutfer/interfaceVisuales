using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasemala2
{
    public partial class recuadro : Form
    {
        public recuadro()
        {
            Timer t1 = new Timer(); 
            t1.Tick += new EventHandler(eventoTimer);
            InitializeComponent();
            t1.Enabled = true;

        }

        private void eventoTimer(object sender, EventArgs e)
        {
            DateTime hoy = DateTime.Now;
            lbl_hora.Text = hoy.ToString("hh : mm : ss");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pb_fondo.Size = new System.Drawing.Size(pb_fondo.Width + 10 , pb_fondo.Width + 10);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            pb_fondo.Size = new System.Drawing.Size(pb_fondo.Width - 10, pb_fondo.Width - 10);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_location_Click(object sender, EventArgs e)
        {
            recuadro f1 = new recuadro();
            int ancho = f1.Width;
            int alto = f1.Height;
            
 
            var rand = new Random();
            int x;
            int y;
            do
            {
                x = rand.Next(0, ancho);
                y = rand.Next(0, alto);
                Console.WriteLine(x.ToString()+""+y.ToString());
            } while (button1.Location.X == x || button1.Location.Y == y || button2.Location.X == x || button2.Location.Y == y);
                pb_fondo.Location = new Point(x, y);

        }
    }
}
