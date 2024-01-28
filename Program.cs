using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia teste");

Smartphone nokia = new Nokia(numero: "123", modelo: "C20", imei: "123", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Iphone teste");

Smartphone iphone = new Iphone(numero: "456", modelo: "13", imei: "456", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");