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
    public partial class MostrarTodos : Form
    {
        private List<inmuebles> todos_los_inmuebles = new List<inmuebles>();
        public MostrarTodos()
        {
            InitializeComponent();
            inizializar_ListItems();
        }

        private void inizializar_ListItems()
        {
            FileStream f1 = new FileStream("inmuebles", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f1);
            try
            {
                while (true)
                {
                    inmuebles inmueble = new inmuebles(br.ReadInt32(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadString(), br.ReadInt32());
                    todos_los_inmuebles.Add(inmueble);
                    listBox1.Items.Add(inmueble.getDireccion() + "-" + inmueble.getPropietario());

                }
            }catch(EndOfStreamException ex) { }
            }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String [] seleccion  = (listBox1.SelectedItem.ToString()).Split('-');
            for (int i = 0; i < todos_los_inmuebles.Count; ++i)
            {
                if (todos_los_inmuebles[i].getDireccion().Equals(seleccion[0]) && todos_los_inmuebles[i].getPropietario().Equals(seleccion[1])) 
                {
                    lb_tipo.Text = "" + todos_los_inmuebles[i].getTipo();
                    lb_telefono.Text = todos_los_inmuebles[i].getTelefono();
                }
            
            }
        }
    }
}
