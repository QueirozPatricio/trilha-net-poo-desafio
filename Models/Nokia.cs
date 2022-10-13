namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone" | por Patrício
    public class Nokia : Smartphone
    {
        // Criando construtor para classe Smartphone | por Patrício
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrever o método "InstalarAplicativo" | por Patrício
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Nokia");
        }
    }
}