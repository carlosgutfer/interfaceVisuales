using System;


namespace gestionDonantes
{
    class Donante
    {
        private String  nombre;
        private String  direccion;
        private int     telefono;
        private Boolean activo;
        private String  grupo;
        private string  factor;
        public Donante(String nombre, string direccion, int telefono, string grupo, string factor)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            this.activo = true;
            this.grupo = grupo;
            this.factor = factor;
        }

        public string getfactor() 
        {
            return factor;
        }
        public string getGrupo()
        {
            return grupo;
        }

        public void setActivo(Boolean activo) 
        {
            this.activo = activo;
        }

        public Boolean getActivo() 
        {
            return activo;
        }
       
        public String getNombre() { return nombre; }

        public int getTelefono() { return telefono; }

        public String getDireccion() { return direccion; }

        public override string ToString()
        {
            return string.Format(this.nombre);
        }
    }
}
