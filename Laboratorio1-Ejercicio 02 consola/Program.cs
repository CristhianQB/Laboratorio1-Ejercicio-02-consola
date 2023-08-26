using System;

//Realiza un programa que reciba una cantidad de minutos y muestre
//por pantalla a cuantashoras y minutos corresponde.
//Por ejemplo: 1000 minutos son 16 horas y 40 minutos.

Console.WriteLine("Cantidad de minutos");
int min = int.Parse(Console.ReadLine());

if (min%60==0)
{
    int horas = min/60;
    Console.WriteLine("Son "+horas +" horas");
}
else
{
    int horas = min / 60;
    int minutos = min%60;
    Console.WriteLine("Son " + horas + " horas y "+minutos+" minutos");
}