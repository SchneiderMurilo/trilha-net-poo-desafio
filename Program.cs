using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Nokia:");
Smartphone nokia = new Nokia("123456", "Nokia Tijolão", "11111111", 4);
nokia.Ligar();
nokia.InstalarAplicativo("zapzap");
nokia.InformacoesSmartphone();


Console.WriteLine("\n");

Console.WriteLine("Iphone:");
Smartphone iphone = new Iphone("123456", "13 pro", "2222222", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("tiktak");
iphone.InformacoesSmartphone();