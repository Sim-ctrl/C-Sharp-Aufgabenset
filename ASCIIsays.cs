using System;
using System.IO;
using System.Collections;
using static System.Net.Mime.MediaTypeNames;

namespace Aufgabe14
{
    internal class ASCIIsays
    {
        static void Main(string[] args)
        {
            ArrayList stringArrayList = new ArrayList();
            Console.WriteLine("Hello, World!");
            Console.WriteLine("WIr erstellen heute ein kleines Pferdchen, das DEINEN Text sagt. Wass soll das Pferdchen sagen?(Leer lassen, wenn kein Text angezeigt werden soll)");
            Console.WriteLine("DU kannst auch einen Zeilenumbruch realisieren: Nutze /n dazu");
            string s = Convert.ToString(Console.ReadLine());

            if (s.Contains("\n\n"))
            {
                Console.WriteLine("Der eingegebene Text enthält Zeilenumbrüche. Sind Sie sicher, dass Sie fortfahren möchten? (ja/nein)");
                string bestätigung = Console.ReadLine();

                if (bestätigung.ToLower() == "nein")
                {
                    Environment.Exit(0);
                }
            }

            string peter = s;
            // peter = "";
            string untStrichObn = "";
            string untStrichUnt = "";

            for (int i = 0; i< peter.Length; i++)
            {
                untStrichObn = untStrichObn + "_";

            }
            for (int i = 0; i < (peter.Length-1); i++)
            {
                untStrichUnt = untStrichUnt + "_";

            }



            string pferd = " ____"+ untStrichObn + "____\r\n/    "+peter+"    \\\r\n\\_____    "+ untStrichUnt+"/\r\n      \\  / \r\n       \\ |  ^^\r\n        \\| (oo)\\_______\r\n           (__)        )\\\r\n               ||----- |\\\\\r\n               ||     ||\r\n";
             string pferdohne = "            ^^\r\n           (oo)\\_______\r\n           (__)        )\\\r\n               ||----- |\\\\\r\n               ||     ||\r\n";

            if (peter.Length == 0) {
                Console.WriteLine(pferdohne);
            }
            else { 
            Console.WriteLine(pferd);
        }}
    }
}
