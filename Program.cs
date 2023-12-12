using Sistema_e_Abstraindo_um_Celular_com_POO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo Z", imei: "111111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whataspp");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "987623", modelo: "Modelo XPG10", imei: "333333333", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");