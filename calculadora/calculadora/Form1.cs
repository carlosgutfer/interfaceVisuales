using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculadora
{
    public partial class Calculadora : Form
    {
        private int numero1;
        private int numero2;
        private String operacion;
        public Calculadora()
        {
            numero1 = 0;
            numero2  = 0;
            operacion = "";
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {
            //cancelar cierre formulario con msg box
        }

        private void numeros_Click(object sender, EventArgs e)
        {
            Button botonAcutal = (Button) sender;
            if ((operacion.Equals("") && numero1 == 0) || (!operacion.Equals("") && numero2 == 0))
                lb_pantalla.Text = "";
            lb_pantalla.Text  += botonAcutal.Text;
            if (operacion.Equals(""))
            {
                if (numero1 == 0)
                    numero1 = Int32.Parse(botonAcutal.Text);
                else
                    numero1 = numero1 * 10 + Int32.Parse(botonAcutal.Text);
            }
            else 
            {
                if (numero2 == 0)
                    numero2 = Int32.Parse(botonAcutal.Text);
                else
                    numero2 = numero2 * 10 + Int32.Parse(botonAcutal.Text);
            }
        }

        private void operacion_Click(object sender, EventArgs e)
        {
            Button botonActual = (Button) sender;
            operacion = botonActual.Text;
            lb_pantalla.Text = "0";
            desactivarClick();
        }

        private void desactivarClick()
        {
            bt_suma.Enabled = false;
            bt_resta.Enabled = false;
            bt_multiplicacion.Enabled = false;
            bt_division.Enabled = false;

        }

        private void bt_igual_Click(object sender, EventArgs e)
        {
            int resultado;

            if (!operacion.Equals(""))
            {
                resultado = 0;
                switch (operacion)
                {
                    case "+":
                        resultado = numero1 + numero2;
                        break;
                    case "-":
                        resultado = numero1 - numero2;
                        break;
                    case "*":
                        resultado = numero1 * numero2;
                        break;
                    case "/":
                        resultado = numero1 / numero2;
                        break;
                }
                lb_pantalla.Text = resultado.ToString();
                limpiarDatos();
                activarClick();
            }
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            Button eleccion = (Button) sender;
            if (eleccion.Text.Equals(bt_borrarAcutal.Text))
            {
                if (operacion.Equals(""))
                    numero1 = 0;
                else
                    numero2 = 0;
            }
            else
            {
                limpiarDatos();
                activarClick();
            }
            lb_pantalla.Text = 0.ToString();
        }

        private void limpiarDatos() 
        {
            numero1 = 0;
            numero2 = 0;
            operacion = "";
        }
        private void activarClick() 
        {
            bt_suma.Enabled = true;
            bt_resta.Enabled = true;
            bt_multiplicacion.Enabled = true;
            bt_division.Enabled = true;
        }
    }
}
