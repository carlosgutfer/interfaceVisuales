using System;
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
    public partial class Alta : Form
    {
        public Alta()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.Equals("1º DAM A") || listBox1.SelectedItem.Equals("1º DAM B"))
            {
                CLB_asignaturas1.Visible = true;
                CLB_aignaturas2.Visible = false;
            }
            else if (listBox1.SelectedItem.Equals("2º DAM A") || listBox1.SelectedItem.Equals("2º DAM B"))
            {
                CLB_aignaturas2.Visible = true;
                CLB_asignaturas1.Visible = false;
            }
        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            if (tb_apellido.Text.Length != 0 && tb_dni.Text.Length != 0 && tb_email.Text.Length != 0 && tb_name.Text.Length != 0 && listBox1.SelectedIndex != -1)
            {
                añadir_alumno();
                añadir_notas();
               DialogResult dr =  MessageBox.Show("Usuario dado de alta correctamente ¿Quiere añadir otro?", "Mensaje", MessageBoxButtons.YesNo);
                if(dr == DialogResult.No)
                    this.Close();
            }
        }

        private void añadir_notas()
        {
            FileStream fs = new FileStream("notas", FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            String[] codigo_asignautra;
            Notas nota;
            if (listBox1.SelectedItem.Equals("1º DAM A") || listBox1.SelectedItem.Equals("1º DAM B"))
                for (int i = 0; i < CLB_asignaturas1.CheckedItems.Count; ++i)
                {
                    codigo_asignautra = (CLB_asignaturas1.CheckedItems[i].ToString()).Split('-');
                    nota = new Notas(tb_dni.Text, Int32.Parse(codigo_asignautra[0].Trim()));
                    bf.Serialize(fs, nota);
                }
            else if (listBox1.SelectedItem.Equals("2º DAM A") || listBox1.SelectedItem.Equals("2º DAM B"))
            {
                for (int i = 0; i < CLB_aignaturas2.CheckedItems.Count; ++i)
                {
                    codigo_asignautra = (CLB_aignaturas2.CheckedItems[i].ToString()).Split('-');
                    nota = new Notas(tb_dni.Text, Int32.Parse(codigo_asignautra[0].Trim()));
                    bf.Serialize(fs, nota);
                }
            }
            fs.Close();
        }

        private void añadir_alumno()
        {
            FileStream fs = new FileStream("alumnos", FileMode.Append, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            Alumno al = new Alumno(tb_name.Text, tb_apellido.Text, tb_dni.Text, tb_email.Text, listBox1.SelectedItem.ToString());
            try
            {
                bf.Serialize(fs, al);
            }
            catch (Exception ex)
            {

            }
            finally { fs.Close(); }
            fs.Close();
        }
    }
}
