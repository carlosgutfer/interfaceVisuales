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
    public partial class NuevoDonante : Form
    {
        private List<Donante> d = new List<Donante>();
        private String factor;
        private Boolean mayor;
        private String grupo;
        public NuevoDonante()
        {
            InitializeComponent();
        }

        internal void pasarParamtro(List<Donante> donantes)
        {
            this.d = donantes;
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {

            if (comprobarMarcado() && factor != null)
            {
               d.Add(new Donante(tb_nombre.Text, tb_direccion.Text, int.Parse(tb_telefono.Text), grupo, factor));
                MessageBox.Show("El usuario se ha registrado correctamente");
                this.Close();
            }
           
        }

        private bool comprobarMarcado()
        {
            Boolean         valido;
            DialogResult    result;

            valido = true;
            if (ck_grupo.CheckedItems.Count == 0)
            {
                result = MessageBox.Show("Seleccione un grupo sanguineo");
                valido = false;
            }
            else
            {
                grupo = "";
                if (ck_grupo.CheckedItems.Count == 2)
                    grupo = "AB";
                else if (ck_grupo.CheckedItems.Count == 1)
                    grupo = ck_grupo.CheckedItems[0].ToString();   
            }
            return valido;
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            tb_nombre.Focus();
            tb_nombre.Text = "";
            tb_telefono.Text = "";
            tb_direccion.Text = "";
        }

        private void rb_negativo_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb.Checked) 
                factor = rb.Text;
        }

        private void rb_menor_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;
            if (rb.Checked) 
            {
                if (rb.Text.Equals("> 18"))
                    mayor = true;
                else
                    mayor = false;
            }
        }

        private void ck_grupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ck_grupo.CheckedItems.IndexOf("0") != -1 && ck_grupo.CheckedItems.Count > 0)
            {
                ck_grupo.SetItemChecked(0, false);
                ck_grupo.SetItemChecked(1, false);
                ck_grupo.SetItemChecked(2, false);

            }

        }

       
    }
}
