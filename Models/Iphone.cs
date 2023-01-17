namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){
        }
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {aplicativo} no Iphone");
            Console.WriteLine("Instalação Concluída!");
        }

        public override void ApresentarSmartphone()
        {
            Console.WriteLine($"Marca: Iphone \nModelo: {Modelo} \nIMEI: {IMEI} \nMemória: {Memoria}GB \nNúmero: {Numero}");
        }

    }
}