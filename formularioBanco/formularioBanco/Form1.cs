using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace formularioBanco
{
    public partial class Form1 : Form
    {

       // List<cliente> todosClientes = new List<cliente>();
        cliente [] arrayClientes = new cliente [0];
        int i = -1;
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
                saldo = double.Parse(txt_saldo.Text);
                if (nombre.Equals("") && !IBAN.Equals(""))
                {
                    lbl_aviso.Text = "El campo nombre no puede estar vacio";
                    txt_nombre.Focus();
                }
                else if (!nombre.Equals("") && IBAN.Equals(""))
                {
                    lbl_aviso.Text = "El campo cuenta no puede estar vacio";
                    txt_cuenta.Focus();

                }
                else if (nombre.Equals("") && IBAN.Equals(""))
                    lbl_aviso.Text = "El campo cuenta y nombre no pueden estar vacios";
                else
                {
                    Array.Resize(ref arrayClientes, arrayClientes.Length + 1);
                    arrayClientes[++i] = new cliente(nombre, IBAN, saldo);
                    // todosClientes.Add(new cliente(nombre, IBAN, saldo));
                    txt_cuenta.Text = "";
                    txt_nombre.Text = "";
                    txt_saldo.Text = "";
                    lbl_aviso.Text = "Usuario registrado correctamente";
                    txt_nombre.Focus();
                }

            }
            catch (Exception) 
            {
                txt_cuenta.Focus();
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
            lbl_clientes.Text = "";
            for (int i = 0; i < arrayClientes.Length; i++)
                lbl_clientes.Text  +=  arrayClientes[i].ToString() +  '\n';
        }
    }

    
}
