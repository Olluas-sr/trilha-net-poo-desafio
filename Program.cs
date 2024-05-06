using DesafioPOO.Models;
Smartphone nokia = new Nokia(numero: "84427788", modelo:"Flip", imei: "556688", memoria:128);
Console.WriteLine($"Nokia sendo iniciado... ");
nokia.Ligar();
nokia.InstalarAplicativo("ZipZop");
// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("\n");

Smartphone iphone = new Iphone(numero: "9955588", modelo:"Ix84", imei: "998822", memoria:240);
Console.WriteLine($"Iphone sendo iniciado... ");
iphone.Ligar();
nokia.InstalarAplicativo("Telegran");