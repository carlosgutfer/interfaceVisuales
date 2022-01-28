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
    public partial class form_buscar_web : Form
    {
        public form_buscar_web()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uri = textBox1.Text;
            if (!uri.Contains("http://") || !uri.Contains("https://"))
                uri = "https://" + uri;
            if (!uri.Contains(".com") || !uri.Contains(".es"))
                uri += ".com";
            Uri nuevaDireccion = new Uri(uri);
            web1.Navigate(nuevaDireccion);
            this.Size = new Size(1000, 1000);
            web1.Size = new Size(1000, 1000);
        }

        private void web1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
           textBox1.Text = web1.Url.ToString();
        }
    }
}
