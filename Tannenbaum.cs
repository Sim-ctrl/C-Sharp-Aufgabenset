using System;
using System.IO;
Console.WriteLine("Hello, World!");
Console.WriteLine("Willkommen in der Baumschule - Gib deine gewollte Höhe an");
Console.WriteLine(" ");
Console.WriteLine(" ");
int hoehe = Convert.ToInt32(Console.ReadLine());
int hoehe1 = hoehe;

for (int j = 0; j < hoehe1; j++)
{
for (int i = 0; i < hoehe; i++) {
    Console.Write(" ");
}
for (int i = 0; i < (hoehe1-hoehe); i++){
        Console.Write("##");}
    Console.Write("#");
    Console.WriteLine("");
    hoehe = hoehe - 1;
    System.Threading.Thread.Sleep(1300);
}

//Fuer den Baumstumpf:
for (int i = 0; i < (hoehe1-1); i++)
{
    Console.Write(" ");
}
Console.Write("|_|");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
