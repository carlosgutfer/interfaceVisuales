using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Gestion_Instituto
{
    [Serializable]
    class Notas 
    {
        private string dni;
        private int codigo_asignatura;
        private int nota;

        public Notas(string dni, int codigo_asignatura) 
        {
            this.dni = dni;
            this.codigo_asignatura = codigo_asignatura;
        }


        public void setNota(int nota) 
        { 
            this.nota = nota;
        }

        public int getNotas() { return nota;}

        public string getDNI() { return dni; }

        public int getCodigoAsignatura() { return codigo_asignatura; }
    }
}
