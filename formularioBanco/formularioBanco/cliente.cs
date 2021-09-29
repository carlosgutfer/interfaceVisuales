namespace formularioBanco
{
    internal class cliente
    {
        private string nombre;
        private string IBAN;
        private double saldo;

       

        public  cliente(string nombre, string IBAN, double saldo) 
        {
            this.nombre = nombre;
            this.IBAN = IBAN;
            this.saldo = saldo;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public string getIBAN() 
        {
            return this.IBAN;
        }

        public double getSaldo() 
        {
            return this.saldo;
        }

        public string toString() 
        {
            return this.nombre + " - " + this.IBAN + " - " + this.saldo;
        }

    }
}