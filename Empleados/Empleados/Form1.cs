using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empleados
{
    public partial class Form1 : Form
    {
        private List<empleadosInfo> todosEmpleados = new List<empleadosInfo>();
        private String eleccionRB;
        public Form1()
        {
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            String  mensaje;

            mensaje = "";
            if (validarDNI(tb_DNI.Text))
            {
                if (validarCorreo(tb_correo.Text)) 
                {
                    if (validarRangoFechas(dt_incorporacion.Value.Year, dt_nacimiento.Value.Year) >= 16) 
                    {
                       todosEmpleados.Add(new empleadosInfo(tb_nombre.Text, tb_apellido.Text, tb_DNI.Text, tb_correo.Text, dt_nacimiento.Value, dt_incorporacion.Value, eleccionRB));
                        mensaje = "El registro se ha hecho de forma exitosa";
                        resetearFormulario();
                    }
                    else
                    {
                        mensaje = "El rango de fecha entrada menos nacimiento es menor a 16 años, revisa los parámetros de entrada. ";
                    }
                }
                else 
                {
                    mensaje = "El correo no es correcto";
                    tb_correo.Focus();
                 }
            }else
            {
                mensaje = "El DNI ya está ne la base de datos";
                tb_DNI.Focus();
            }
            lbl_informacion.Text = mensaje;

        }

        private void resetearFormulario()
        {
            tb_nombre.Text = "";
            tb_nombre.Focus();
            tb_apellido.Text = "";
            tb_correo.Text = "";
            tb_DNI.Text = "";
            dt_incorporacion.Value = dt_incorporacion.MaxDate;
            dt_nacimiento.Value = dt_nacimiento.MaxDate;
        }

        private void rb_operarios_CheckedChanged(object sender, EventArgs e)
        {
            eleccionRB = rb_operarios.Text;
        }

        private void rb_Jefe_CheckedChanged(object sender, EventArgs e)
        {
            eleccionRB = rb_Jefe.Text;

        }

        private void rb_mantenimiento_CheckedChanged(object sender, EventArgs e)
        {
            eleccionRB = rb_mantenimiento.Text;

        }

        private void bt_Operario_Click(object sender, EventArgs e)
        {
            empleadosInfo  [] consulta;
            consulta = (empleadosInfo[]) mostrarConsulta(bt_Operario.Text).Clone();
            for (int i = 0; i < consulta.Length; ++i)
                    lbl_busqueda.Text = lbl_busqueda.Text + consulta[i].toString() + '\n';
        }

        private  empleadosInfo [] mostrarConsulta(string text)
        {   
            empleadosInfo [] nuevoArray = new empleadosInfo[0];

            for(int i = 0; i < todosEmpleados.Count; ++i)
                if ((todosEmpleados[i].getPuesto()).Equals(text)) 
                {
                    Array.Resize(ref nuevoArray, nuevoArray.Length + 1);
                    nuevoArray[nuevoArray.Length - 1] = todosEmpleados[i];
                }            
            return nuevoArray;     
        }

        private void bt_jefe_Click(object sender, EventArgs e)
        {
            empleadosInfo[] consulta;
            consulta = (empleadosInfo[])mostrarConsulta(bt_jefe.Text).Clone();
            for (int i = 0; i < consulta.Length; ++i)
                lbl_busqueda.Text = lbl_busqueda.Text + consulta[i].ToString();
        }

        private void bt_mantenimiento_Click(object sender, EventArgs e)
        {
            empleadosInfo[] consulta;
            consulta = (empleadosInfo[])mostrarConsulta(bt_mantenimiento.Text).Clone();
            for (int i = 0; i < consulta.Length; ++i)
                lbl_busqueda.Text = lbl_busqueda.Text + consulta[i].ToString();
        }

        private Boolean validarDNI(String DNI)
        {
            Boolean valido;

            valido = true;
            for (int i = 0; i < todosEmpleados.Count && valido; ++i)
                if (DNI.Equals(todosEmpleados[i].getDNI()))
                    valido = false;
            return valido;
        }

        private Boolean validarCorreo(String correo)
        {
            if (correo.Contains("@"))
                return true;
            else
                return false;
        }

        private int validarRangoFechas(int fechaInicio, int fehcaNacimiento)
        {
            return fechaInicio - fehcaNacimiento;
        }

    }
}
