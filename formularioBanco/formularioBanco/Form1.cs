using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace formularioBanco
{
    public partial class Form1 : Form
    {

        List<cliente> todosClientes = new List<cliente>();
        public Form1()
        {
            InitializeComponent();

        }

        private void TItular_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_aceptar_Click(object sender, EventArgs e)
        {
            String  nombre;
            String IBAN;
            double saldo;

            nombre = txt_nombre.Text;
            IBAN = txt_cuenta.Text;
            try
            {
                saldo = Double.Parse(txt_saldo.Text);
                if (nombre.Equals("") && !IBAN.Equals(""))
                    lbl_aviso.Text = "El campo nombre no puede estar vacio";
                else if (!nombre.Equals("") && IBAN.Equals(""))
                    lbl_aviso.Text = "El campo cuenta no puede estar vacio";
                else if (nombre.Equals("") && IBAN.Equals(""))
                    lbl_aviso.Text = "El campo cuenta y nombre no pueden estar vacios";
                else
                {
                    todosClientes.Add(new cliente(nombre, IBAN, saldo));
                    txt_cuenta.Text = "";
                    txt_nombre.Text = "";
                    txt_saldo.Text = "";
                    lbl_aviso.Text = "Usuario registrado correctamente";

                }

            }
            catch (Exception ex) 
            {
                lbl_aviso.Text = "Error en el campo saldo";
            }

        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            txt_cuenta.Text = "";
            txt_nombre.Text = "";
            txt_saldo.Text = "";

        }

        private void bt_consultar_Click(object sender, EventArgs e)
        {
          
            for (int i = 0; i < todosClientes.Count; i++)
                lbl_clientes.Text = lbl_clientes.Text + todosClientes[i].toString();
        }
    }
}
