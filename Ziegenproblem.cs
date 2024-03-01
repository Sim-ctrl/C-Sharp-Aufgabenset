using System;

class Ziegenproblem
{
    static void Main(string[] args)
    {
        int anzahlDurchgänge = 200;
        int erfolgeBleiben = 0;
        int erfolgeWechseln = 0;

        Random zufall = new Random();

        for (int i = 0; i < anzahlDurchgänge; i++)
        {
            int gewinnTür = zufall.Next(3); // Zufällige Auswahl der Tür mit dem Gewinn

            int ersteWahl = zufall.Next(3); // Kandidat wählt zuerst eine Tür

            // Tür, die der Moderator öffnet (kann nicht die Gewinn-Tür oder die erste Wahl des Kandidaten sein)
            int öffnenTür = zufall.Next(3);

            while (öffnenTür == gewinnTür || öffnenTür == ersteWahl)//Damit weder die gewinnende Tür noch die bereits gewählte Tür gewählt wird.
                {
                    öffnenTür = zufall.Next(3);
                } 



            /////// Kandidat bleibt
            if (ersteWahl == gewinnTür)
            {
                erfolgeBleiben++;
            }



            ///////////////// Kandidat wechseltt
            int neueWahl=zufall.Next(3);
            
            while (neueWahl == ersteWahl || neueWahl == öffnenTür){ // Damit wählt er die andere Seite aus
                neueWahl = zufall.Next(3);
            } 

            if (neueWahl == gewinnTür)
            {
                erfolgeWechseln++;
            }
        }

        Console.WriteLine("Erfolge beim Bleiben: " + erfolgeBleiben);    // eine 33% Wahl
        Console.WriteLine("Erfolge beim Wechseln: " + erfolgeWechseln); // eine 50% Wahl

        string s = Convert.ToString(Console.ReadLine());
    }
}
