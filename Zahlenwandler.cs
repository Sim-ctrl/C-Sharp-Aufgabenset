using System;

namespace Auf13
{
     public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo, Welt!");
            Console.WriteLine("Jetzt wird meine Methode aufgerufen---");
            MeineMethode();
            // ausgabeMethode();
            string essasdfgm = Console.ReadLine();
        }

        static void MeineMethode()
        {
            Console.WriteLine("Gib deine Zahl an und wir wandeln sie in die einfache Schriftform");
            Console.WriteLine();
            Console.WriteLine();

            try
            {
                string inputNumber = Console.ReadLine();
               // inputNumber = Reverse(inputNumber);
                if (int.TryParse(inputNumber, out int number))
                {
                    string output = ZahlInWorteKonvertieren(number);
                    Console.WriteLine(output);
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine gültige Zahl ein.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Fehler: {ex.Message}");
            }
        }

        public static string ZahlInWorteKonvertieren(int eingabe)
        {
            int i = eingabe;
            string gedrehteeingabe = "" + Reverse(i + ""); // an dieser stelle wird die Zahl 142 zur 241 der Einfachheit halber

            
            string zahl = gedrehteeingabe + "";
            string ausgabe = "";



            ///////////////////// MILLIONEN (unten)
            if (zahl.Length >= 7)
            {
                if (zahl[6] == '1') { ausgabe = ausgabe + "eine"; }
                if (zahl[6] == '2') { ausgabe = ausgabe + "zwei"; }
                if (zahl[6] == '3') { ausgabe = ausgabe + "drei"; }
                if (zahl[6] == '4') { ausgabe = ausgabe + "vier"; }
                if (zahl[6] == '5') { ausgabe = ausgabe + "fünf"; }
                if (zahl[6] == '6') { ausgabe = ausgabe + "sechs"; }
                if (zahl[6] == '7') { ausgabe = ausgabe + "sieben"; }
                if (zahl[6] == '8') { ausgabe = ausgabe + "acht"; }
                if (zahl[6] == '9') { ausgabe = ausgabe + "neun"; }
                if (zahl[6] != '0') { ausgabe = ausgabe + "millionen"; } 
            }

            //////////////////////////////////// TAUSEND (unten)
            if (zahl.Length >= 6)
            {
                if (zahl[5] == '1') { ausgabe = ausgabe + "ein"; }
                if (zahl[5] == '2') { ausgabe = ausgabe + "zwei"; }
                if (zahl[5] == '3') { ausgabe = ausgabe + "drei"; }
                if (zahl[5] == '4') { ausgabe = ausgabe + "vier"; }
                if (zahl[5] == '5') { ausgabe = ausgabe + "fünf"; }
                if (zahl[5] == '6') { ausgabe = ausgabe + "sechs"; }
                if (zahl[5] == '7') { ausgabe = ausgabe + "sieben"; }
                if (zahl[5] == '8') { ausgabe = ausgabe + "acht"; }
                if (zahl[5] == '9') { ausgabe = ausgabe + "neun"; }
                if (zahl[5] != '0') { ausgabe = ausgabe + "hundert"; } // HUNDERT 
            }
            if (zahl.Length >= 4)
            {
                // 124 - 421
                if (zahl[3] == '1' ) { ausgabe = ausgabe + "ein"; }
                if (zahl[3] == '2' ) { ausgabe = ausgabe + "zwei"; }
                if (zahl[3] == '3') { ausgabe = ausgabe + "drei"; }
                if (zahl[3] == '4') { ausgabe = ausgabe + "vier"; }
                if (zahl[3] == '5') { ausgabe = ausgabe + "fünf"; }
                if (zahl[3] == '6') { ausgabe = ausgabe + "sechs"; }
                if (zahl[3] == '7') { ausgabe = ausgabe + "sieben"; }
                if (zahl[3] == '8') { ausgabe = ausgabe + "acht"; }
                if (zahl[3] == '9') { ausgabe = ausgabe + "neun"; }
            }
            if (zahl.Length >= 5)
            {
                if (zahl[4] == '1' && zahl[3] != '0')// 12222 wird zu 25461
                {
                    if (zahl[3] == '1' || zahl[3] == '2')
                    {
                        if (zahl[3] == '1') { ausgabe = ausgabe + "elf"; }
                        if (zahl[3] == '2') { ausgabe = ausgabe + "zwölf"; }
                    }
                    else
                    {
                        ausgabe = ausgabe + "zehn";
                    }


                    if (zahl[3] == '0') { ausgabe = "zehn"; }
                }
                else
                {
                    if (zahl[4] == '0' && zahl.Length == 5) { ausgabe = ausgabe + ""; } // Zahlen wie 070 nur als "siebzig" ausgeben
                    else if (zahl[4] == '0' && zahl[3] != '0') { ausgabe = ausgabe + "zig"; } // Zahlen wie 700 nur als "siebenhundert" ausgeben
                    else
                    {
                        if (zahl[3] != '0') { ausgabe = ausgabe + "und"; }
                        if (zahl[4] == '1') { ausgabe = ausgabe + "zehn"; }
                        if (zahl[4] == '2') { ausgabe = ausgabe + "zwanzig"; }
                        if (zahl[4] == '3') { ausgabe = ausgabe + "dreißig"; }
                        if (zahl[4] == '4') { ausgabe = ausgabe + "vierzig"; }
                        if (zahl[4] == '5') { ausgabe = ausgabe + "fünfzig"; }
                        if (zahl[4] == '6') { ausgabe = ausgabe + "sechzig"; }
                        if (zahl[4] == '7') { ausgabe = ausgabe + "siebzig"; }
                        if (zahl[4] == '8') { ausgabe = ausgabe + "achtzig"; }
                        if (zahl[4] == '9') { ausgabe = ausgabe + "neunzig"; }
                    }
                }
            }
            /////////////////////////////// HUNDERT (unten)
            
            if (zahl.Length >= 4)
            {
                if (zahl[3] != '0' || zahl[0] != '0') { ausgabe = ausgabe + "tausend"; }
            }
if (zahl.Length >= 3)
{
    if (zahl[2] == '1') { ausgabe = ausgabe+  "ein"; }
    if (zahl[2] == '2') { ausgabe = ausgabe + "zwei"; }
    if (zahl[2] == '3') { ausgabe = ausgabe + "drei"; }
    if (zahl[2] == '4') { ausgabe = ausgabe + "vier"; }
    if (zahl[2] == '5') { ausgabe = ausgabe + "fünf"; }
    if (zahl[2] == '6') { ausgabe = ausgabe + "sechs"; }
    if (zahl[2] == '7') { ausgabe = ausgabe + "sieben"; }
    if (zahl[2] == '8') { ausgabe = ausgabe + "acht"; }
    if (zahl[2] == '9') { ausgabe = ausgabe + "neun"; }
    if (zahl[2] != '0' ) { ausgabe = ausgabe + "hundert"; } // HUNDERT 
}

// 124 - 421
if (zahl[0] == '1' && zahl[1] != '1') { ausgabe = ausgabe + "eins"; }
if (zahl[0] == '2' && zahl[1] != '1') { ausgabe = ausgabe + "zwei"; }
if (zahl[0] == '3') { ausgabe = ausgabe + "drei"; }
if (zahl[0] == '4') { ausgabe = ausgabe + "vier"; }
if (zahl[0] == '5') { ausgabe = ausgabe + "fünf"; }
if (zahl[0] == '6') { ausgabe = ausgabe + "sechs"; }
if (zahl[0] == '7') { ausgabe = ausgabe + "sieben"; }
if (zahl[0] == '8') { ausgabe = ausgabe + "acht"; }
if (zahl[0] == '9') { ausgabe = ausgabe + "neun"; }

if (zahl.Length >= 2)
{
    if (zahl[1] == '1' && zahl[0] != '0')// 12222 wird zu 25461
    {
        if (zahl[0] == '1' || zahl[0] =='2') { if (zahl[0] == '1') { ausgabe = ausgabe + "elf"; } if (zahl[0] == '2') { ausgabe = ausgabe + "zwölf"; } 
        } else { 
        ausgabe = ausgabe + "zehn";}


    if (zahl[0]=='0') { ausgabe = "zehn"; }
    }
    else
    {
        if (zahl[1] == '0' && zahl.Length == 2) { ausgabe = ausgabe + ""; } // Zahlen wie 070 nur als "siebzig" ausgeben
        else if (zahl[1] == '0' && zahl[0] != '0') { ausgabe = ausgabe + "zig"; } // Zahlen wie 700 nur als "siebenhundert" ausgeben
        else
        {
            if (zahl[0] != '0') { ausgabe = ausgabe + "und"; }
            if (zahl[1] == '1') { ausgabe = ausgabe + "zehn"; }
            if (zahl[1] == '2') { ausgabe = ausgabe + "zwanzig"; }
            if (zahl[1] == '3') { ausgabe = ausgabe + "dreißig"; }
            if (zahl[1] == '4') { ausgabe = ausgabe + "vierzig"; }
            if (zahl[1] == '5') { ausgabe = ausgabe + "fünfzig"; }
            if (zahl[1] == '6') { ausgabe = ausgabe + "sechzig"; }
            if (zahl[1] == '7') { ausgabe = ausgabe + "siebzig"; }
            if (zahl[1] == '8') { ausgabe = ausgabe + "achtzig"; }
            if (zahl[1] == '9') { ausgabe = ausgabe + "neunzig"; }
        }
    }
}

return ausgabe;




}


public static string Reverse(string s)
{
char[] charArray = s.ToCharArray();
Array.Reverse(charArray);

return new string(charArray);

}

}
}