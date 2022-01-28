using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_Instituto
{
    public partial class Baja : Form
    {
        private static bool baja;

        public Baja()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dni = textBox1.Text;
            if (!dni.Equals(""))
            {


                DialogResult dr = MessageBox.Show("Está seguro que desea dar de baja al usuario. Este proceso es irreversible", "Baja definitiva", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    dar_de_baja(dni);
                    if (baja)
                    {
                        MessageBox.Show("El usuario ha sido dado de baja correctamente");
                        this.Close();
                    }
                    else { MessageBox.Show("ERROR, no existe ningún usuario con ese DNI", "ERROR"); }
                }
                else if (dr == DialogResult.No)
                { };

            }
        }

        private static void dar_de_baja(string dni)
        {
            FileStream fs = new FileStream("alumnos", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            ArrayList alumnos = new ArrayList();


            FileStream fs2 = new FileStream("auxiliar", FileMode.Append, FileAccess.Write);
            BinaryFormatter bf2 = new BinaryFormatter();

            try
            {
                while(true)
                    alumnos.Add((Alumno)bf.Deserialize(fs));
            }
            catch (Exception ex) { }

            foreach (Alumno al in alumnos)
            {
                if (al.getDni().Equals(dni))
                {
                    al.setEstado('B');
                    baja = true;
                }
                bf2.Serialize(fs2, al);

            }
            fs2.Close();
            fs.Close();
            File.Delete("alumnos");
            File.Move("auxiliar", "alumnos");
        }
    }
}
