using System;


namespace Empleados
{
    class empleadosInfo
    {
        String nombre;
        string apellido;
        string DNI;
        string email;
        DateTime fechaNacimiento;
        DateTime fechaIncorporacion;
        String puesto;

        public empleadosInfo(string nombre, string apellido, string dNI, string email, DateTime fechaNacimiento, DateTime fechaIncorporacion, string puesto)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.DNI = dNI;
            this.email = email;
            this.fechaNacimiento = fechaNacimiento;
            this.fechaIncorporacion = fechaIncorporacion;
            this.puesto = puesto;
        }

        public string toString() 
        {
            return "nombre: " + this.nombre + " apellido: " + this.apellido + " DNI: " + this.DNI + " email: " + this.email + " fecha nacimiento: " + this.fechaNacimiento.ToString() + " fehca incorporacion: " + this.fechaIncorporacion.ToString() + " puesto: " + this.puesto;
        }

        public String getDNI() 
        {
            return this.DNI;
        }

        public String getPuesto()
        {
            return this.puesto;
        }
    }
}
