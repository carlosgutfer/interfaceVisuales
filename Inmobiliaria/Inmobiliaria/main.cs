using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void nmuebleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem eleccion = (ToolStripMenuItem) sender;
            if (eleccion.Name.Equals("SM_Nuevo")) 
            {
                nuevo form_nuevo = new nuevo();
                this.Hide();
                form_nuevo.ShowDialog();
                this.Show();
            }else if (eleccion.Name.Equals("SM_consulta_todos")) 
            {
                MostrarTodos f = new MostrarTodos();
                this.Hide();
                f.Show();
                this.Show();
            }

         }

        private void main_Load(object sender, EventArgs e)
        {

        }
    }
}
