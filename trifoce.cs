using System.Collections;
using System.Text;
using System.Text.RegularExpressions;

namespace Auf18Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string filePath = @"C:\triforce.txt"; // Pfad zur Textdatei
            Console.WriteLine("Heute erstellen wir ein Dreieck, gib bitte die Grösse an");
            int input = Convert.ToInt32(Console.ReadLine());

            // Größe des Triforces
            SierpinskiTriangle sierpinskiTriangle = new SierpinskiTriangle(input);
            // Rufe die Display-Methode auf, um das Sierpinski-Dreieck anzuzeigen
            sierpinskiTriangle.Display();
            sierpinskiTriangle.Write(filePath);
        }
    }

    class SierpinskiTriangle
    {
        int len = 3;
        BitArray b;
        string loesung = "";
        public SierpinskiTriangle(int n)
        {
            //ArrayList stringListZwei = new ArrayList();

            if (n < 1)
            {
                throw new ArgumentOutOfRangeException("Order must be greater than zero");
            }
            len = 1 << (n + 1);
            b = new BitArray(len + 1, false);
            b[len >> 1] = true;
        }

         public void Display()
         {
             for (int j = 0; j < len / 2; j++)
             {
                 for (int i = 0; i < b.Count; i++)
                 {
                     Console.Write("{0}", b[i] ? "A" : " ");
                     loesung = loesung + ("{0}", b[i] ? "A" : " ");
                 }
                 Console.WriteLine();
                 loesung += "\n";
                 NextGen();
             }
         }




        /*public string Display()
        {
            StringBuilder sb = new StringBuilder();

            for (int j = 0; j < len / 2; j++)
            {
                for (int i = 0; i < b.Count; i++)
                {
                    sb.Append(b[i] ? "A" : " ");
                }
                sb.AppendLine();
                NextGen();
            }

            return sb.ToString();
        }
        */
        private void NextGen()
        {
            BitArray next = new BitArray(b.Count, false);
            for (int i = 0; i < b.Count; i++)
            {
                if (b[i])
                {
                    next[i - 1] = next[i - 1] ^ true;
                    next[i + 1] = next[i + 1] ^ true;
                }
            }
            b = next;
        }

        public void Write(string filePath)
        {

            /* char[] charsToReplace = { '{', '}', '0', '(', ')', ',' };
             string replacement = "";
             string replacedString = loesung;
             // Durchlaufen Sie jeden Charakter im Eingabestring
             foreach (char c in charsToReplace)
             {
                 // Ersetzen Sie das aktuelle Zeichen durch das Ersatzzeichen
                 replacedString = replacedString.Replace(c, replacement[0]);
             }
             */


           // Console.WriteLine("Ursprungs: ");
            // Console.WriteLine(loesung);
            

            string jedesZeite = RemoveExtraSpaces(loesung);
            //jedesZeite = RemoveBracketsAndCommas(loesung);
            //Console.WriteLine("String bei dem aufeinanderfolgende gelöscht wurden: ");
           // Console.WriteLine(jedesZeite);

            string ohnePausehinterKomma = RemoveSpaceBeforeA(jedesZeite);
           // Console.WriteLine("Hier wurden auch noch die Leerzeichen vor A entfernt:");
           // Console.WriteLine(ohnePausehinterKomma);

           
            string result = RemoveBracketsAndCommas(ohnePausehinterKomma);
            //Console.WriteLine("String ohne geschweifte/runde Klammern und Kommas: ");
           // Console.WriteLine(result);

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(result);
            }


            Console.WriteLine("Der String wurde erfolgreich in die Datei geschrieben: " + filePath);
        }
        static string RemoveBracketsAndCommas(string input)
        {
            // Verwende regulären Ausdruck, um geschweifte Klammern, runde Klammern und Kommas zu entfernen
            string result = Regex.Replace(input, @"[{}(),0]", "");
            return result;
        }
        static string RemoveEverySecondSpace(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int spaceCount = 0;
            foreach (char c in input)
            {
                if (c == ' ')
                {
                    spaceCount++;
                    if (spaceCount % 2 == 0)
                    {
                        continue; // Überspringe jedes zweite Leerzeichen
                    }
                }
                resultBuilder.Append(c);
            }

            return resultBuilder.ToString();
        }
        static string RemoveExtraSpaces(string input)
        {
            char previousChar = '\0'; // Initiales vorheriges Zeichen als Platzhalter
            string result = "";

            foreach (char currentChar in input)
            {
                if (!(previousChar == ' ' && currentChar == ' ')) // Prüfe, ob beide aufeinanderfolgende Zeichen Leerzeichen sind
                {
                    result += currentChar; // Füge das aktuelle Zeichen zum Ergebnis hinzu, wenn keine aufeinanderfolgenden Leerzeichen gefunden wurden
                }
                previousChar = currentChar; // Aktualisiere das vorherige Zeichen
            }

            return result;
        }
        static string RemoveSpaceBeforeA(string input)
        {
            StringBuilder resultBuilder = new StringBuilder();

            int length = input.Length;
            for (int i = 0; i < length-1; i++)
            {
                if (input[i+1] == 'A' && i > 0 && input[i] == ' ')
                {
                    // Ersetze das Leerzeichen direkt vor 'A' durch einen leeren String
                    resultBuilder.Append("");
                }
                else
                {
                    resultBuilder.Append(input[i]); // Füge das aktuelle Zeichen zum Ergebnis hinzu
                }
            }

            return resultBuilder.ToString();
        }
    }

}
