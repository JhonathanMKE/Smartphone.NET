namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string IMEI, string Modelo, int Memoria) : base(numero, IMEI, Modelo, Memoria) { }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando aplicativo " + nomeApp + " no Iphone");
        }
    }
}