using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionaIES
{
    public partial class GestionaIES : Form
    {
        public GestionaIES()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has pulsado Cancelar");
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {

            String user = txt_user.Text;
            String password = txt_password.Text;

            if ((user == "1234") && (password == "1234"))
            {
                Form2 new_form = new Form2();
                this.Close();

                new_form.Show();
            }

            /*
            Label new_label = new Label();
            new_label.Text = "Prueba";
            new_label.Location = new System.Drawing.Point(500, 25);
            new_label.Size = new System.Drawing.Size(70, 20);
            this.Controls.Add(new_label);*/
        }

        private void txt_user_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
