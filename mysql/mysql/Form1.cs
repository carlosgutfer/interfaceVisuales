using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mysql
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'colegioDataSet2.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter2.Fill(this.colegioDataSet2.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'colegioDataSet1.cambios' Puede moverla o quitarla según sea necesario.
            this.cambiosTableAdapter1.Fill(this.colegioDataSet1.cambios);
            // TODO: esta línea de código carga datos en la tabla 'colegioDataSet1.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter1.Fill(this.colegioDataSet1.alumnos);
            // TODO: esta línea de código carga datos en la tabla 'pruebaDataSet.tabla1' Puede moverla o quitarla según sea necesario.
            this.tabla1TableAdapter.Fill(this.pruebaDataSet.tabla1);
            // TODO: esta línea de código carga datos en la tabla 'colegioDataSet.cambios' Puede moverla o quitarla según sea necesario.
            this.cambiosTableAdapter.Fill(this.colegioDataSet.cambios);
            // TODO: esta línea de código carga datos en la tabla 'colegioDataSet.alumnos' Puede moverla o quitarla según sea necesario.
            this.alumnosTableAdapter.Fill(this.colegioDataSet.alumnos);

        }
    }
}
