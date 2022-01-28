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
    public partial class PonerNotas : Form
    {
        ArrayList alumnos = new ArrayList();
        ArrayList notas_alumno = new ArrayList();
        public PonerNotas(String curso)
        {
            InitializeComponent();
            FileStream fs = new FileStream("alumnos", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            
            try
            {
                while (true)
                {
                    Alumno alumno = (Alumno)bf.Deserialize(fs);
                    if (alumno.getCurso().Equals(curso) && alumno.getEstado().Equals('A'))
                        alumnos.Add(alumno);
                }
            }
            catch (Exception ex) { }
            foreach (Alumno al in alumnos)
                listBox1.Items.Add(al.getApellido() + "-" + al.getNombre());

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            notas_alumno.Clear();
            FileStream fs = new FileStream("notas", FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            try 
            {
                Notas nota;
                Alumno alumno = (Alumno) alumnos[listBox1.SelectedIndex];
                while (true)
                {
                    nota = (Notas)bf.Deserialize(fs);
                    if (alumno.getDni().Equals(nota.getDNI()))
                        notas_alumno.Add(nota);
                }
            } catch (Exception ex)
            { 
            
            }
            fs.Close();
            modificar_ventana();


        }

        private void modificar_ventana()
        {
            int i = 1;
            foreach(Notas n in notas_alumno) 
            {
                if (i == 1)
                {
                    label1.Visible = true;
                    label1.Text = asignatura(n.getCodigoAsignatura());
                    textBox1.Visible = true;
                }
                else if (i == 2)
                {
                    label2.Visible = true;
                    label2.Text = asignatura(n.getCodigoAsignatura());
                    textBox2.Visible = true;
                }
                else if (i == 3)
                {
                    label3.Visible = true;
                    label3.Text = asignatura(n.getCodigoAsignatura());
                    textBox3.Visible = true;
                }
                else if (i == 4)
                {
                    label4.Visible = true;
                    label4.Text = asignatura(n.getCodigoAsignatura());
                    textBox4.Visible = true;
                }
                else if (i == 5)
                {
                    label5.Visible = true;
                    label5.Text = asignatura(n.getCodigoAsignatura());
                    textBox5.Visible = true;
                }
                else if (i == 6)
                {
                    label6.Visible = true;
                    label6.Text = asignatura(n.getCodigoAsignatura());
                    textBox6.Visible = true;
                }
                else if (i == 7)
                {
                    label7.Visible = true;
                    label7.Text = asignatura(n.getCodigoAsignatura());
                    textBox7.Visible = true;
                }
                else if (i == 8)
                {
                    label8.Visible = true;
                    label8.Text = asignatura(n.getCodigoAsignatura());
                    textBox8.Visible = true;
                }
                else if (i == 9)
                {
                    label9.Visible = true;
                    label9.Text = asignatura(n.getCodigoAsignatura());
                    textBox9.Visible = true;
                }
                i++;
            }
            for (int j = i; j < 10; j++)
                if (j == 1)
                {
                    label1.Visible = false;
                    textBox1.Visible = false;
                }else if(j == 2) 
                {
                    label1.Visible = false;
                    textBox1.Visible = false;
                }
                else if (j == 3)
                {
                    label3.Visible = false;
                    textBox3.Visible = false;
                }
                else if (j == 4)
                {
                    label4.Visible = false;
                    textBox4.Visible = false;
                }
                else if (j == 5)
                {
                    label5.Visible = false;
                    textBox5.Visible = false;
                }
                else if (j == 6)
                {
                    label6.Visible = false;
                    textBox6.Visible = false;
                }
                else if (j == 7)
                {
                    label7.Visible = false;
                    textBox7.Visible = false;
                }
                else if (j == 8)
                {
                    label8.Visible = false;
                    textBox8.Visible = false;
                }
                else if (j == 9)
                {
                    label9.Visible = false;
                    textBox9.Visible = false;
                }
                
        }

        private string asignatura(int v)
        {
            String valor = "";
            switch (v) 
            {
                case 1:
                    valor = "Programación";
                    break;
                case 2:
                    valor = "BBDD";
                    break;
                case 3:
                    valor = "FOL";
                    break;
                case 4:
                    valor = "Lenguaje de marcas";
                    break;
                case 5:
                    valor = "Sistemas informáticos";
                    break;
                case 6:
                    valor = "Entornos de desarrollo";
                    break;
                case 7:
                    valor = "SGE";
                    break;
                case 8:
                    valor = "Interfaces";
                    break;
                case 9:
                    valor = "Móviles";
                    break;
                case 10:
                    valor = "Inglés";
                    break;
                case 11:
                    valor = "EIE";
                    break;
                case 12:
                    valor = "Acceso a datos";
                    break;
                case 13:
                    valor = "Prácticas";
                    break;
                case 14:
                    valor = "Proyecto final de grado";
                    break;
            }
            return valor;
        }
    }

    
}
