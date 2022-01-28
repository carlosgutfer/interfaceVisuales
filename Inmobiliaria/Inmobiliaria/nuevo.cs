using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class nuevo : Form
    {
        private int venta_alquiler;
        private inmuebles nuevo_inmueble;
        private List<inmuebles> todos_los_inmubles = new List<inmuebles>();

        public nuevo()
        {
            InitializeComponent();
        }

        private void bt_Aceptar_Click(object sender, EventArgs e)
        {
            int tipo;
            string direccion, localidad, propietario, telefono, email;

            if (listBox1.SelectedItem != null) 
            {
                tipo = tipo_elegido();
                direccion = mismaLongitud(tb_direccion.Text); 
                localidad = mismaLongitud(tb_direccion.Text);
                propietario = mismaLongitud(tb_propietario.Text);
                telefono = mismaLongitud(tb_telefono.Text);
                email = mismaLongitud(tb_email.Text);
               
                //nuevo_inmueble = new inmuebles(tipo, direccion, localidad, propietario, telefono, email, venta_alquiler);
                //todos_los_inmubles.Add(nuevo_inmueble);

                FileStream fs = new FileStream("inmuebles", FileMode.Append, FileAccess.Write);
                BinaryWriter bw = new BinaryWriter(fs);
                bw.Write(tipo);
                bw.Write(direccion);
                bw.Write(localidad);
                bw.Write(propietario);
                bw.Write(telefono);
                bw.Write(email);
                bw.Write(venta_alquiler);
                bw.Close();
                fs.Close();
                this.Close();
            }


        }

        private string mismaLongitud(string text)
        {
            while (text.Length < 20)
                text += " ";
            return text;
        }

        private void rb_ventas_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton eleccion = (RadioButton) sender;
            if (eleccion.Name == "rb_alquiler")
                venta_alquiler = 0;
            else if (eleccion.Name == "rb_ventas")
                venta_alquiler = 1;

        }

        private int tipo_elegido() 
        {
            int tipo = -1;

            if (listBox1.SelectedItem == "Local")
                tipo = 0;
            else if (listBox1.SelectedItem == "Piso")
                tipo = 1;
            else if (listBox1.SelectedItem == "Chalet")
                tipo = 2;
            return tipo;
        }

        private void nuevo_Load(object sender, EventArgs e)
        {

        }
    }
}
