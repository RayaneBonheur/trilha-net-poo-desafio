using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero : "123456", modelo: "Nokia G60", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iphone");
Smartphone iphone = new Iphone(numero : "789101", modelo: "15 Pro Max", imei: "222222222", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");