using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace clasesmalas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha;
            fecha = fecha_cumple.Value;
            lbl_respuesta.Text = fecha.ToString();
            ;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            int diasSeleccionados;
            int diaInicial = calendario.SelectionStart.Day;
            int diaFInal = calendario.SelectionEnd.Day;

            if (diaInicial < 22 || (diaFInal == 31 && diaInicial == 22))
                diasSeleccionados = calendario.SelectionEnd.Day - calendario.SelectionStart.Day;
            else
                diasSeleccionados = calendario.SelectionEnd.Day + 30 - calendario.SelectionStart.Day;

            if (diasSeleccionados == 9)
            {
                lbl_inicio.Text = calendario.SelectionStart.ToShortDateString();
                lbl_fin.Text = calendario.SelectionEnd.ToShortDateString();

            }
        }
    }
}
