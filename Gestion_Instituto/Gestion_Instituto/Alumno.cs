using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Instituto
{
    [Serializable]
    class Alumno 
    {
        private string nombre;
        private string apellido;
        private string dni;
        private string email;
        private char estado;
        private string curso;

        public  Alumno(string nombre, string apellido, string dni, string email, string curso) 
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.email = email;
            this.estado = 'A';
            this.curso = curso;
        }

        public string getDni() { return dni;}

        public string getCurso() { return curso; }

        public string getNombre() { return nombre;}

        public string getApellido() { return apellido;}

        public char getEstado() { return estado;}

        public void setEstado(char estado) { this.estado = estado; }

       
        public String mostrarDatos() { return nombre + '-' + apellido + '-' + dni + "-" + email + '-' + curso + '\n'; }
    }
}
