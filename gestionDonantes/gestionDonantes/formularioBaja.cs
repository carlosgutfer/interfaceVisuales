using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionDonantes
{
    public partial class formularioBaja : Form
    {
        private Donante donanteElegido;
        private List<Donante> d = new List<Donante>();
        public formularioBaja()
        {
            InitializeComponent();
        }

        private void lb_resultadoBusqueda_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                donanteElegido = (Donante)lb_resultadoBusqueda.SelectedItem;
                lbl_telefono.Text = donanteElegido.getTelefono().ToString();
                lbl_direccion.Text = donanteElegido.getDireccion();
                lbl_activo.Text = donanteElegido.getActivo().ToString();
                lbl_grupo.Text = donanteElegido.getGrupo();
                lbl_factor.Text = donanteElegido.getfactor();
            }
            catch (Exception) { }
        }

        internal void pasarParamtro(List<Donante> donantes)
        {
            this.d = donantes;
        }

        private void bt_baja_Click(object sender, EventArgs e)
        {
            try 
            {
                donanteElegido.setActivo(false);
                lbl_activo.Text = donanteElegido.getActivo().ToString();
            }
            catch (Exception) 
            {
                lbl_error.Text = "No hay ningún usuario seleccionado";
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            lb_resultadoBusqueda.Items.Clear();
            for (int i = 0; i < d.Count; ++i)
            {
                if (d[i].getNombre().Equals(tb_nombreUsuario.Text))
                {
                    lb_resultadoBusqueda.Items.Add(d[i]);
                }
            }
        }
    }
}
