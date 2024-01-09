using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Iphone iphone = new("0000-0001", "modeliphone", "igft678", 256);
Nokia nokia = new("0000-0002", "modelnokia", "igft679", 64);

iphone.InstalarAplicativo("Twitter");

Console.WriteLine("///////");


nokia.InstalarAplicativo("Facebook");