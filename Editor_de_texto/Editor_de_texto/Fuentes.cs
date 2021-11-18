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
    public partial class Fuentes : Form
    {
        Main f1;
        public Fuentes(Main form1)
        {
            InitializeComponent();
            this.f1 = form1;
            tb_prueba.Text = "ABC";
        }

        private void rb_f1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton) sender;
            String name = rb.Name;
            if(name == "rb_f1") 
            {
                cambiar_texto("Arial", 1);
            }
            else if(name == "rb_f2") 
            {
                cambiar_texto("Algerian", 1);
            }
                else if(name == "rb_f3") 
            {
                cambiar_texto("Times New Roman", 1);            
            }
            else 
            {
                cambiar_texto("Microsoft Sans Serif", 1);
            }

        }

        private void rb_negrita_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            String name = rb.Name;
            if (name.Equals("rb_negrita"))
            {
                cambiar_texto("1", 2);
            }
            else if (name.Equals("rb_cursiva"))
            {
                cambiar_texto("2", 2);
            }
            else if (name.Equals("rb_subrayado"))
                cambiar_texto("4", 2);
            else
            {
                cambiar_texto("8", 2);
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            String name = rb.Name;

            if (name.Equals("rb_8")) 
            {
                cambiar_texto("8", 3);
            } else if (name.Equals("rb_10")) 
            {
                cambiar_texto("10", 3);
            }
            else
            {
                cambiar_texto("12", 3);

            }
        }

        public void cambiar_texto(String dato, int tipo)
        {
            if (tipo == 1)
            {
                tb_prueba.Font = new Font(dato, tb_prueba.Font.Size, tb_prueba.Font.Style);
            }
            else if (tipo == 2)
            {
                tb_prueba.Font = new Font(tb_prueba.Font.FontFamily, tb_prueba.Font.Size, (FontStyle)int.Parse(dato));
            }
            else
            {
                tb_prueba.Font = new Font(tb_prueba.Font.FontFamily, float.Parse(dato), tb_prueba.Font.Style);
            }
            f1.cambiar_texto_main(dato, tipo);
        }
    }
}
