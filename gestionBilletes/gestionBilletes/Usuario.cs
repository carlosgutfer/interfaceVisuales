namespace gestionBilletes
{
    internal class Usuario
    {
        private string nombre;
        private string DNI;
        private string tlf;
        private string email;
        private int    numPlaza;
        
        public  Usuario(string nombre, string DNI, string tlf, string email) 
        {
            this.nombre = nombre;
            this.DNI = DNI;
            this.tlf = tlf;
            this.email = email;
            this.numPlaza = 0;
        }

        public void setNumPlaza(int numPlaza) 
        {
            this.numPlaza = numPlaza;
        }
        public int getNumPlaza() 
        {
            return numPlaza;
        }

        public string getDNI() 
        {
            return DNI;
        }
    }
}