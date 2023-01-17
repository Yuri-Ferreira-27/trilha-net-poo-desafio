namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria){

        }

        
        // TODO: Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string aplicativo)
        {
            Console.WriteLine($"Instalando o aplicativo {aplicativo} no Nokia");
            Console.WriteLine("Instalação Concluída!");
        }

        public override void ApresentarSmartphone()
        {
            Console.WriteLine($"Marca: Nokia \nModelo: {Modelo} \nIMEI: {IMEI} \nMemória: {Memoria}GB \nNúmero: {Numero}");
        }
    }
}