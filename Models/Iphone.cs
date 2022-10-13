namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone" | por Patrício
    public class Iphone : Smartphone
    {
        // Criando construtor para classe Smartphone | por Patrício
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrever o método "InstalarAplicativo" | por Patrício
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no Iphone");
        }
    }
}