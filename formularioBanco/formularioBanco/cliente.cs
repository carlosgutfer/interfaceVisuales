namespace formularioBanco
{
    internal class cliente
    {
        private string nombre;
        private string iBAN;
        private double saldo;

        public cliente(string nombre, string iBAN, double saldo)
        {
            this.nombre = nombre;
            this.iBAN = iBAN;
            this.saldo = saldo;
        }
        public override string ToString()
        {
            return "Nombre: " + this.nombre + " IBAN: " + this.iBAN + " saldo: " + this.saldo;
        }
    }
}