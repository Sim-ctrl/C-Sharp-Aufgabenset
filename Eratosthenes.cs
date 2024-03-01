using System;
using System.IO;
Console.WriteLine("Hello, World!");
int[] students = new int[98];


for (int i = 2; i < 100; i++)
{
    students[(i-2)] = i;
}


for (int j = 0; j < students.Length; j++)
{ Console.Write(students[j]+" ");
}

///////////////////////Durch 2
Thread.Sleep(4000);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Jetzt berechnen wir die Reihe, wenn zudem jede durch 2 teilbare Zahl gestrichen wird "); 
Thread.Sleep(4000);


for (int j = 0; j < students.Length; j++) {

    if (students[j]%2!=0) { Console.Write(students[j]+" "); }
}

/////////////////////////Durch 3
Thread.Sleep(4000);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Jetzt berechnen wir die Reihe, wenn zudem jede durch 3 teilbare Zahl gestrichen wird ");
Thread.Sleep(4000);


for (int j = 0; j < students.Length; j++)
{
    if (students[j] % 2 != 0) { if (students[j] % 3 != 0) { Console.Write(students[j] + " "); } }
}

/////////////////////////Durch 5
Thread.Sleep(4000);
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine("Jetzt berechnen wir die Reihe, wenn zudem jede durch 5 teilbare Zahl gestrichen wird ");
Thread.Sleep(4000);

for (int j = 0; j < students.Length; j++)
{
    if (students[j] % 2 != 0) { if (students[j] % 3 != 0) { if (students[j] % 5 != 0) { Console.Write(students[j] + " "); } } }
}

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" ");