using System.Collections;

namespace AUfgabe17
{
    internal class manhattan
    {
        static void Main(string[] args)
        {

            //Blickrichtungen:
            /*
            Boolean nord = true;
            Boolean ost=false;
            Boolean sud = false;
            Boolean west = false;
            int gameBoardOben = 10;
            int gameBoardSeite = 10;*/
            ArrayList arlist = new ArrayList();

            StreamReader sr = new StreamReader("C:\\bbb.txt");
            //Read the first line of text
            string line = sr.ReadLine();
            arlist.Add(line);
            //Continue to read until you reach end of file

            while (line != null)
            {
                //write the line to console window
                Console.WriteLine(line);
                //Read the next line
                line = sr.ReadLine();
                arlist.Add(line);        // arlist[ZEILE]
            }

            sr.Close();
            Console.WriteLine("Hello, World!");
            

            for (int k = 0; k < arlist.Count-1; k++) {


                Boolean nord = true;
                Boolean ost = false;
                Boolean sud = false;
                Boolean west = false;
                int gameBoardOben = 10;
                int gameBoardSeite = 10;


                string[,] gameBoard = new string[19, 20]
            ////////////////////////7//////ObenUnten, RechtsLinks
       {
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
    { "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O", "O" },
       };

            gameBoard[gameBoardOben, gameBoardSeite] = "S";

            string eingabe = (arlist[k]+"").ToLower();

           // string eingabe = "LLGRGGGRGGGGLRGGRGG";
            eingabe = eingabe.ToLower();

            for (int i = 0; i < eingabe.Length; i++)
            {

                if (eingabe[i] == 'r')
                {
                    Boolean done = true;
                    if (nord && done)
                    {
                        gameBoardSeite ++;
                        nord = false; done = false;
                        ost = true;
                    }
                    if (ost && done)
                    {
                        gameBoardOben= gameBoardOben+1;
                        ost = false; done = false;
                        sud = true;
                    }
                    if (sud && done)
                    {
                        gameBoardSeite = gameBoardSeite - 1;
                        sud = false; done = false;
                        west = true;
                    }
                    if (west&&done)
                    {
                        gameBoardOben = gameBoardOben - 1;
                        west = false; done = false;
                        nord = true;
                    }
                    gameBoard[gameBoardOben, gameBoardSeite] = "R";
                }

                if (eingabe[i] == 'l')
                {
                    Boolean done = true;
                    if (nord&&done)
                    {
                        gameBoardSeite = gameBoardSeite -1;
                        nord = false; done = false;
                        west = true;
                    }
                    if (west && done)
                    {
                        gameBoardOben = gameBoardOben + 1;
                        west = !west; done = false;
                        sud = true;
                    }
                    if (sud && done)
                    {
                        gameBoardSeite = gameBoardSeite +1;
                        sud = false; done = false;
                        ost = true;
                    }
                    if (ost && done)
                    {
                        gameBoardOben = gameBoardOben - 1;
                        ost = false; done = false;
                        nord = true;
                    }
                    gameBoard[gameBoardOben, gameBoardSeite] = "L";
                }
                if (eingabe[i] == 'g')
                {
                    //Boolean done = true;
                    if (nord) {
                        gameBoardOben--;
                     
                    }
                    if (ost)
                    {
                        gameBoardSeite++;
                    }
                    if (sud)
                    {
                        gameBoardOben++;
                    }
                    if (west)
                    {
                        gameBoardSeite--;
                    }
                    gameBoard[gameBoardOben, gameBoardSeite] = "G";
                }


                //gameBoard[gameBoardOben, gameBoardSeite] = "1";
            }
            gameBoard[gameBoardOben, gameBoardSeite] = "E";


                Console.WriteLine("Gemalt wird: "+arlist[k] + "");
                //UM DAS GAMEBOARD AUSZUGEBEN
            for (int i = 0; i < gameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < gameBoard.GetLength(1); j++)
                {
                    Console.Write(gameBoard[i, j] + " ");
                }
                Console.WriteLine(); // Zum Umbruch zur nächsten Zeile
            }
            //double erst = Math.Pow(gameBoardOben - gameBoardSeite, 2);
            //double zweit = Math.Pow(10 - 10, 2);

            double doublegameBoardOben = gameBoardOben + 0.0;
            double doublegameBoardSeite = gameBoardSeite + 0.0;

            double distance = Math.Sqrt(Math.Pow(doublegameBoardOben - 10.0, 2.0) + Math.Pow(doublegameBoardSeite - 10.0, 2.0));

            Console.WriteLine("gameBoardOben :" + doublegameBoardOben + "gameBoardSeite: " + doublegameBoardSeite);
            
            Console.WriteLine("Die Entfernung lautet hier etwa "+ (int)((distance*100)+0.5) + " Meter");
            Console.WriteLine("Diezurückgelegte Strecke war: " +((eingabe.Length)*100)+ "") ;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            }
            string bestätigung = Console.ReadLine();

        }
    }
}
