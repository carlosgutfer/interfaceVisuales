using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Editor_de_texto
{
    public partial class Main : Form
    {

        String palabraAcutal;
        public Main()
        {
            InitializeComponent();
        }

        

        private void fuentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (sender.ToString().Equals("Fuentes"))
            {
                Fuentes f = new Fuentes(this);
                f.ShowDialog();

            }
            else if (sender.ToString().Equals("Abrir"))
            {
                OpenFileDialog ofd = new OpenFileDialog();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    var fileStream = ofd.OpenFile();
                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        string fileContent = reader.ReadToEnd();
                        tb_main.Text = fileContent;
                    }
                }
            }
            else if (sender.ToString().Equals("Guardar"))
            {
                Stream mystream;
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "Todos los archivos(*.*) | *.*|" +
                "Archivos texto(*.txt)| *.txt |" +
                "Archivos gráficos | *.gif,*.jpg";
                sfd.RestoreDirectory = true;
                sfd.FilterIndex = 2;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if ((mystream = sfd.OpenFile()) != null)
                    {
                        mystream.Close();
                    }
                }
            }
        }

        internal void buscar(string palabra)
        {
            if (palabraAcutal != "")
                tb_main.SelectionStart += 1; 
            int posicionActual = tb_main.SelectionStart;
            tb_main.SelectionLength = palabra.Length;
            String comparar = tb_main.SelectedText;
            Boolean encontrada = false;
            while (!encontrada)
            {
                if (comparar.Equals(palabra))
                {
                    tb_main.Select(posicionActual, palabra.Length);
                    tb_main.Focus();
                    palabraAcutal = palabra;
                    encontrada = true;
                }
                else if (posicionActual < tb_main.TextLength)
                {
                    posicionActual++;
                    tb_main.SelectionStart = posicionActual;
                    tb_main.SelectionLength = palabra.Length;
                    comparar = tb_main.SelectedText;
                }
                else
                {
                    MessageBox.Show("No se han encontrado más registros");
                    encontrada = true;
                    palabraAcutal = "";
                }
            }
        }

        public void cambiar_texto_main(String dato, int tipo)
        {
            if (tipo == 1)
            {
                tb_main.Font = new Font(dato, tb_main.Font.Size, tb_main.Font.Style);
            }
            else if (tipo == 2)
            {
                tb_main.Font = new Font(tb_main.Font.FontFamily, tb_main.Font.Size, (FontStyle)int.Parse(dato));
            }
            else
            {
                tb_main.Font = new Font(tb_main.Font.FontFamily, float.Parse(dato), tb_main.Font.Style);
            }
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Colores f = new Colores(this);
            f.ShowDialog();
        }

        public void cambiar_color(Color c, int cambio) 
        {
            if (cambio == 1)
                tb_main.BackColor = c;
            else
                tb_main.ForeColor = c;
        }

        private void cortarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem mi = (ToolStripMenuItem)sender;
            String nombre = mi.Name;
            if (nombre.Equals("mi_cortar"))
            {
                tb_main.Cut();
            }
            else if (nombre.Equals("mi_eliminar"))
            {
                tb_main.SelectedText = "";
            }
            else if (nombre.Equals("mi_copiar"))
            {
                tb_main.Copy();
            }
            else if (nombre.Equals("mi_buscar"))
            {
                form_buscar f = new form_buscar(this);
                f.Show();
            }
            else if (nombre.Equals("mi_pegar"))
            {
                tb_main.Paste();
            }
            else if (nombre.Equals("mi_web"))
            {
                form_buscar_web f = new form_buscar_web();
                f.Show();
            }
        }

        private void tb_main_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.F) 
            {
                form_buscar f = new form_buscar(this);
                f.Show();
            }
        }
    }
}
