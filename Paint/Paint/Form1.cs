using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        Boolean pintar;
        int puntoXAnterior;
        int puntoYAnterior;
        int tipoEntradaTexto = 1;
        char [] numeroDecimales = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
        char [] numerosOctales =  {'1', '2', '3', '4', '5', '6', '7', '0' };
        char [] numerosBinarios = {'0', '1'};
        public Form1()
        {
            InitializeComponent();
        }


    

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel)sender;
            Graphics g = panel.CreateGraphics();
            Pen p = new Pen(Color.Black);
            int nuevoPuntoX = e.X;
            int nuevoPuntoY = e.Y;
            Point point1 = new Point(puntoXAnterior, puntoYAnterior);
            Point point2 = new Point(e.X, e.Y);

            if (pintar == true)
            {
                g.DrawLine(p, point1, point2);
                puntoXAnterior = e.X;
                puntoYAnterior = e.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            puntoXAnterior = e.X;
            puntoYAnterior = e.Y;
            pintar = true;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            pintar = false;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            String name = rb.Name;
            if (name.Equals("rb_decimal")) 
            {
                tipoEntradaTexto = 1;
            }
            else if (name.Equals("rb_octal"))
            {
                tipoEntradaTexto = 2;

            }
            else if (name.Equals("rb_binario")) 
            {
                tipoEntradaTexto = 3;
            }
            textBox1.Text = "";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8)
            {
                if (tipoEntradaTexto == 1 && !numeroDecimales.Contains(e.KeyChar))
                {
                    e.Handled = true;
                } else if (tipoEntradaTexto == 3 && !numerosBinarios.Contains(e.KeyChar)) 
                {
                    e.Handled = true;
                }else if(tipoEntradaTexto == 2 && !numerosOctales.Contains(e.KeyChar)) 
                {
                    e.Handled = true;
                }
            }
        }
    }
}
