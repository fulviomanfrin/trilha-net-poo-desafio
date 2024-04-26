using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
var nokia = new Nokia("988556668", "Nokia1", "7777888999554", 16);
var iphone = new Iphone("988886668", "Iphone 13", "7777888669554", 16);

Console.WriteLine("Smartphone Nokia:");

nokia.InstalarAplicativo("WhatsApp");
nokia.Ligar();
nokia.ReceberLigacao();

Console.WriteLine("----------------------------------------------");

Console.WriteLine("Smartphone Iphone:");
iphone.InstalarAplicativo("Telegram");
iphone.Ligar();
iphone.ReceberLigacao();

Console.WriteLine("----------------------------------------------");
