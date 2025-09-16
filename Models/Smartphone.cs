namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string IMEI { get; set; }
        private string Modelo { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string p_numero, string p_IMEI, string p_Modelo, int p_Memoria)
        {
            Numero = p_numero;
            IMEI = p_IMEI;
            Modelo = p_Modelo;
            Memoria = p_Memoria;
            
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}