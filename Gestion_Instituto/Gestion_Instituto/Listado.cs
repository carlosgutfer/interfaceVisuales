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
    public partial class Listado : Form
    {
        public Listado(String curso)
        {
            InitializeComponent();
            FileStream fs = new FileStream("alumnos", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            ArrayList alumnos = new ArrayList();
            try
            {
                while (true)
                {
                    Alumno alumno = (Alumno)bf.Deserialize(fs);
                    alumnos.Add(alumno);
                } 
            }
            catch (Exception ex) { }
            foreach (Alumno al in alumnos) 
            { 
                if(al.getCurso().Equals(curso) && al.getEstado().Equals('A')) 
                {
                    lb_mostrar.Text += al.mostrarDatos();
                }
            }

        }

        private void Listado_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
