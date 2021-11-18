using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace gestionDonantes
{
    public partial class mainForm : Form
    {
        private List<Donante>       donantes = new List<Donante>();
  

        public mainForm()
        {
            InitializeComponent();
        }

        private void nuevoDonanteToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (sender.ToString() == "Nuevo donante")
            {
                NuevoDonante f = new NuevoDonante();
                f.pasarParamtro(donantes);
                aperturaCierreDialog(f);
            }
            else if (sender.ToString() == "Baja donante") 
            {
                formularioBaja f = new formularioBaja();
                f.pasarParamtro(donantes);
                aperturaCierreDialog(f);
            }else if(sender.ToString() == "Busqueda donante") 
            {
                buscarDonante f = new buscarDonante();
                f.pasarParamtro(donantes);
                aperturaCierreDialog(f);
            }
        }

        private void aperturaCierreDialog(Form f)
        {
            this.Hide();
            f.ShowDialog();
            this.Show();
        }


        private void tiposDisponiblesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem seleccion = (ToolStripMenuItem)sender;
            if (seleccion.Name == "tiposDisponibles")
            {
                tiposDisponibles f = new tiposDisponibles();
                f.pasarParametro(donantes);
                aperturaCierreDialog(f);
            }
            else if (seleccion.Name == "disponibilidadPorTipos")
            {

            }

        }
    }
}
