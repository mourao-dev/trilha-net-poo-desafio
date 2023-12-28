﻿using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "111111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "67890", modelo: "Modelo 2", imei: "0000000", memoria: 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Telegram");