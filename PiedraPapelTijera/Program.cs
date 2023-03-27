// See https://aka.ms/new-console-template for more information
using PiedraPapelTijera;

Console.WriteLine("Hello, World!");

Juego ob = new Juego();
Piedra objPiedra = new Piedra();
Papel objPapel = new Papel();
Tijera objTijera = new Tijera();


Console.WriteLine(ob.comprobacionJuegoObjetos(objPiedra, objTijera));
