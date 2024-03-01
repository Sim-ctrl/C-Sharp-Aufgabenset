using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
/*Das Programm soll auf einer Konsole ein Jahr einlesen und ausgeben, ob das Jahr ein Schaltjahr ist oder nicht.
Regeln für ein Schaltjahr:
•	Jahr muss durch 4 teilbar sein
•	Darf nicht durch 100 teilbar sein, 
•	Außer es ist auch durch 400 teilbar
*/

Console.WriteLine("Gib bitte ein Jahr an. Ich verrate dir, ob es sich um ein Schaltjahr handelt");
int zahl1 = Convert.ToInt32(Console.ReadLine());
if ((zahl1 % 4 == 0 && zahl1 % 100 != 0) || (zahl1 % 400 == 0))
{
    Console.WriteLine("Bei dem Jahr " + zahl1 + " handelt es sich um ein Schaltjahr");
    System.Environment.Exit(1);
}
Console.WriteLine("Das einzige was hier Schaltet, ist der GTI Fahrer an einem Kindergarten (er schaltet runter)");