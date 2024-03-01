using System;
using System.IO;
/*Aus dem Italienischen Mathematiker Leonardo Fibonacci ging eine Zahlenreihe hervor die das
 * Wachstum einer Kaninchenpopulation beschreiben konnte. Jedes Element in der Zahlenreihe wird 
 * dadurch definiert, dass es die Summe ist aus den beiden vorhergehenden Zahlen.
1,1,2,3,5,8,13,21…
Schreibe ein Programm, dass diese Zahlenfolge auf die Konsole ausgeben kann. Dies soll auf 
zwei Arten gelöst werden. Iterativ und Rekursiv.
*/
// See https://aka.ms/new-console-template for more information


//Iterativ:
/*Console.WriteLine("Hello, World!");
int j = 1;
int k = 1;
//Console.Write(j + ",");
for (int i = 0; i < 10; i++) {
   
    
    Console.Write((j)+",");
    j = k + j;
    Console.Write((k) + ",");
    k = k + j;



    }
*/




//Exkursiv:
Console.WriteLine("Hello, World!");

for (int i = 0; i < 10; i++)
{
    Console.Write(Fibonacci(i) + " ");
}

static int Fibonacci(int n) { 
if (n <= 1)
{
    return n;
}
return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
