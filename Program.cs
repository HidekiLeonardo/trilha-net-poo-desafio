using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Tijolo", imei: "11111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone:");
Smartphone iphone = new Iphone(numero: "56789", modelo: "Modelo Chique", imei: "222222222", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");
// TODO: Realizar os testes com as classes Nokia e Iphone