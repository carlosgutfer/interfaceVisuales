using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inmobiliaria
{

    class inmuebles
    {
        private int tipo;
        private string direccion;
        private string localidad;
        private string propietario;
        private string telefono;
        private string email;
        private int venta_alquiler;

        public inmuebles(int tipo, string direccion, string localidad, string propietario, string telefono, string email, int venta_alquiler)
        {
            this.tipo = tipo;
            this.direccion = direccion;
            this.localidad = localidad;
            this.propietario = propietario;
            this.telefono = telefono;
            this.email = email;
            this.venta_alquiler = venta_alquiler;
        }

        public int getTipo() { return tipo; }

        public int getVenta_Alquiler() { return venta_alquiler; }

        public String getPropietario() { return propietario; }
        public String getDireccion() { return direccion; }

        public String getlocalidad() { return localidad; }

        public String getTelefono() { return telefono; }

        public int getVentaAlquiler(){ return venta_alquiler; }

    }
}
