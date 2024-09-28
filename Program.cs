using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Smartphone nokia1 = new Nokia("13981325972", "Nokia", "5620", 128);
Console.WriteLine("Smartphone Nokia:");
nokia1.Ligar();
nokia1.ReceberLigacao();
nokia1.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Smartphone iphone1 = new Iphone("1397340136", "Iphone15", "2056", 256);
Console.WriteLine("Smartphone Iphone:");
iphone1.Ligar();
iphone1.ReceberLigacao();
iphone1.InstalarAplicativo("Telegram");