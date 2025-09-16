using DesafioPOO.Models;

//Teste 1 - Instância de Nokia e Instalação de APP
Nokia nokia = new Nokia("1102", "ACB", "XDFS", 32);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Mapas");

//Teste 2 - Instância de Iphone e Instalação de APP
Iphone iphone = new Iphone("1103", "AFD", "XPCS", 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Mapas");
