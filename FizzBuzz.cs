// See https://aka.ms/new-console-template for more information
/*Das Programm soll von 1 bis hundert alle Zahlen auf der Konsole ausgeben.
Wenn die Zahl durch 3 teilbar ist, soll statt der Zahl das Wort "Fizz" ausgegeben werden.
Wenn die Zahl durch 5 teilbar ist soll statt der Zahl das Wort "Buzz" ausgegeben werden.
Wenn die Zahl durch 3 als auch durch 5 teilbar ist, soll das Wort "FizzBuzz" ausgegeben werden.
Wenn keine der Bedingungen zutrifft, dann soll die Zahl selbst ausgegeben werden.
1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13…
*/
Console.WriteLine("Hello, World!");
for (int i = 0; i < 101; i++)
{

    //Füer den Fall, dass es weder durch 3 noch durch 5 teilbar ist
    if ((i % 3 != 0) && (i % 5 != 0))
    {
        Console.WriteLine(i);
    }
    //Für den Fall, das´s es durch 3 und durch 5 Teilbar ist
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine("FizzBuzz");
    }
    //Für den Fall, dass es nur durch 3 Teilbar ist
    if ((i % 3 == 0) && (i % 5 != 0))
    {
        Console.WriteLine("Buzz");
    }
    if ((i % 3 != 0) && (i % 5 == 0))
    {
        Console.WriteLine("Fizz");
    }
}