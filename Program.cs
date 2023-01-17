using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Testando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "12345678", modelo: "Lumia 520", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.ApresentarSmartphone();
nokia.InstalarAplicativo("Facebook");
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Testando o Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "98712364", modelo: "Iphone 11", imei: "22222", memoria: 128);
iphone.Ligar();
iphone.ApresentarSmartphone();
iphone.InstalarAplicativo("Spotify");
iphone.InstalarAplicativo("Instagram");


