using Microsoft.VisualBasic.Devices;

namespace MySecondForms
{
    public partial class Form1 : Form
    {
        //uebertrageArray();
        Boolean spielerGelb = true;
        Boolean computer = true;
        Boolean riskantGesetzt = false;
        public string[][] spielfeld = new string[6][]
        {
         new string[]{"", "", "", "", "", "", ""},
         new string[]{"", "", "", "", "", "", ""},
         new string[]{"", "", "", "", "", "", ""},
         new string[]{"", "", "", "", "", "", ""},
         new string[]{"", "", "", "", "", "", ""},
         new string[]{"", "", "", "", "", "", ""}
        };
        
        public Form1()
        {
            InitializeComponent();//spielfeld[1][2]="G";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        public void prüfeArray()
        {
            // Vertikale Überprüfung
            for (int i = 0; i < spielfeld.Length; i++)
            {
                for (int j = 0; j <= spielfeld[i].Length - 4; j++)
                {
                    if (spielfeld[i][j] == "R" && spielfeld[i][j + 1] == "R" && spielfeld[i][j + 2] == "R" && spielfeld[i][j + 3] == "R")
                    {
                        rotGewinnt();
                        return;
                    }
                    else if (spielfeld[i][j] == "G" && spielfeld[i][j + 1] == "G" && spielfeld[i][j + 2] == "G" && spielfeld[i][j + 3] == "G")
                    {
                        grünGewinnt();
                        return;
                    }
                }
            }

            // Horizontale Überprüfung
            for (int i = 0; i <= spielfeld.Length - 4; i++)
            {
                for (int j = 0; j < spielfeld[i].Length; j++)
                {
                    if (spielfeld[i][j] == "R" && spielfeld[i + 1][j] == "R" && spielfeld[i + 2][j] == "R" && spielfeld[i + 3][j] == "R")
                    {
                        rotGewinnt();
                        return;
                    }
                    else if (spielfeld[i][j] == "G" && spielfeld[i + 1][j] == "G" && spielfeld[i + 2][j] == "G" && spielfeld[i + 3][j] == "G")
                    {
                        grünGewinnt();
                        return;
                    }
                }
            }

            // Diagonale Überprüfung (von links oben nach rechts unten)
            for (int i = 0; i <= spielfeld.Length - 4; i++)
            {
                for (int j = 0; j <= spielfeld[i].Length - 4; j++)
                {
                    if (spielfeld[i][j] == "R" && spielfeld[i + 1][j + 1] == "R" && spielfeld[i + 2][j + 2] == "R" && spielfeld[i + 3][j + 3] == "R")
                    {
                        rotGewinnt();
                        return;
                    }
                    else if (spielfeld[i][j] == "G" && spielfeld[i + 1][j + 1] == "G" && spielfeld[i + 2][j + 2] == "G" && spielfeld[i + 3][j + 3] == "G")
                    {
                        grünGewinnt();
                        return;
                    }
                }
            }

            // Diagonale Überprüfung (von links unten nach rechts oben)
            for (int i = 3; i < spielfeld.Length; i++)
            {
                for (int j = 0; j <= spielfeld[i].Length - 4; j++)
                {
                    if (spielfeld[i][j] == "R" && spielfeld[i - 1][j + 1] == "R" && spielfeld[i - 2][j + 2] == "R" && spielfeld[i - 3][j + 3] == "R")
                    {
                        rotGewinnt();
                        return;
                    }
                    else if (spielfeld[i][j] == "G" && spielfeld[i - 1][j + 1] == "G" && spielfeld[i - 2][j + 2] == "G" && spielfeld[i - 3][j + 3] == "G")
                    {
                        grünGewinnt();
                        return;
                    }
                }
            }


            if (computer&& !spielerGelb) {
                // Thread.Sleep(2000);
                //spielerGelb = !spielerGelb;

                riskant();
                if (riskantGesetzt) { uebertrageArray(); }
                if (!riskantGesetzt) { 
                Random random = new Random();
                // Generiere eine zufällige Zahl zwischen 1 und 7 (einschließlich)
                int randomNumber = random.Next(1, 8);
                if (randomNumber == 1 && a1.Text == "") { fuerEins(); } else if (randomNumber == 1) { randomNumber = 2; }
                if (randomNumber == 2 && a2.Text == "") { fuerZwei(); } else if (randomNumber == 2) { randomNumber = 3; }
                if (randomNumber == 3 && a3.Text == "") { fuerDrei(); } else if (randomNumber == 3) { randomNumber = 4; }
                if (randomNumber == 4 && a4.Text == "") { fuerVier(); } else if (randomNumber == 4) { randomNumber = 5; }
                if (randomNumber == 5 && a5.Text == "") { fuerFunf(); } else if (randomNumber == 5) { randomNumber = 6; }
                if (randomNumber == 6 && a6.Text == "") { fuerSechs(); } else if (randomNumber == 6) { randomNumber = 7; }
                if (randomNumber == 7 && a7.Text == "") { fuerSiebn(); } else if (randomNumber == 7){ fuerEins(); }
                }
                riskantGesetzt = false;
            }
        }


        private void riskant() { // Horizontal prüfen ob 3 mal R in der Reihe ist, dannschmuggelt er sich mit seinem G dazwischen
    for (int i = 0; i< 6; i++)
    {
        for (int j = 0; j< 4; j++)
        {
            if (spielfeld[i][j] == "R" && spielfeld[i][j + 1] == "R" && spielfeld[i][j + 2] == "R" && spielfeld[i][j + 3] == "")
            {
                spielfeld[i][j + 3] = "G"; riskantGesetzt = true; //Funktioniert (Getestet - ja in der Waage)

                        return;
            }
}
    }

    for (int i = 5; i >= 3; i--)// Vertikal prüfen ob 3 in Reihe sdn
{
    for (int j = 6; j >= 0; j--)
    {
        if (spielfeld[i][j] == "R" && spielfeld[i - 1][j] == "R" && spielfeld[i - 2][j] == "R" && spielfeld[i - 3][j] == "")
        {
            spielfeld[i - 3][j] = "G"; riskantGesetzt = true;
                        return;
        }
    }
}

// Diagonal (von links oben nach rechts unten) prüfen
for (int i = 0; i < 3; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (spielfeld[i][j] == "R" && spielfeld[i + 1][j + 1] == "R" && spielfeld[i + 2][j + 2] == "R" && spielfeld[i + 3][j + 3] == "" && spielfeld[i + 4][j + 3] != "")
        {
            spielfeld[i + 3][j + 3] = "G"; riskantGesetzt = true;
                        return;
        }
    }
}

// Diagonal (von links unten nach rechts oben) prüfen
for (int i = 3; i < 6; i++)
{
    for (int j = 0; j < 4; j++)
    {
        if (spielfeld[i][j] == "R" && spielfeld[i - 1][j + 1] == "R" && spielfeld[i - 2][j + 2] == "R" && spielfeld[i - 3][j + 3] == "" && spielfeld[i - 2][j + 3] != "")
        {
            spielfeld[i - 3][j + 3] = "G"; riskantGesetzt = true;
                        return;
        }
    }
}

            

        }

        private void rotGewinnt()
        {
            Console.WriteLine("Rot gewinnt!");
            BackColor = Color.Red;
            textBox.Text = "Rot gewinnt!";
            this.Enabled = false;
            textBox.BackColor = Color.White;
        }

        private void grünGewinnt()
        {
            Console.WriteLine("Grün gewinnt!");
            BackColor = Color.Green;
            textBox.Text = "Grün gewinnt!";
            textBox.BackColor = Color.White;
            this.Enabled = false;
        }

        private void a1_Click(object sender, EventArgs e)
        {
            // InitializeComponent();

            // Formularhintergrundfarbe ändern
            // BackColor = Color.Green;
            // a1.Text = "G";
            //Console.WriteLine("a1.Text"+ a1.Text);
            // Hintergrundfarbe der Schaltfläche ändern
            // a1.ForeColor = Color.Red;

            // a1.BackColor = Color.Green;
            // a1.ForeColor = Color.LightBlue;
            fuerEins();
        }

        private void fuerEins()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][0] == "")
                {

                    if (spielerGelb)
                    {
                        spielfeld[i][0] = "R";
                    }
                    else { spielfeld[i][0] = "G"; }
                    uebertrageArray();
                    return; // Sobald die unterste leere Zelle gefunden wurde, beenden wir die Methode
                }
            }

            //BackColor = Color.Green;
        }
        private void fuerZwei()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][1] == "")
                {

                    if (spielerGelb)
                    {
                        spielfeld[i][1] = "R";
                    }
                    else { spielfeld[i][1] = "G"; }
                    uebertrageArray();
                    return; // Sobald die unterste leere Zelle gefunden wurde, beenden wir die Methode
                }
            }

            //BackColor = Color.Green;
        }
        private void fuerDrei()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][2] == "")
                {
                    if (spielerGelb)
                    {
                        spielfeld[i][2] = "R";
                    }
                    else { spielfeld[i][2] = "G"; }
                    uebertrageArray();
                    return;
                }
            }
        }
        private void fuerVier()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][3] == "")
                {
                    if (spielerGelb)
                    {
                        spielfeld[i][3] = "R";
                    }
                    else { spielfeld[i][3] = "G"; }
                    uebertrageArray();
                    return;
                }
            }
        }
        private void fuerFunf()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][4] == "")
                {
                    if (spielerGelb)
                    {
                        spielfeld[i][4] = "R";
                    }
                    else { spielfeld[i][4] = "G"; }
                    uebertrageArray();
                    return;
                }
            }
        }
        private void fuerSechs()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][5] == "")
                {
                    if (spielerGelb)
                    {
                        spielfeld[i][5] = "R";
                    }
                    else { spielfeld[i][5] = "G"; }
                    uebertrageArray();
                    return;
                }
            }
        }
        private void fuerSiebn()
        {
            for (int i = spielfeld.Length - 1; i >= 0; i--)
            {
                if (spielfeld[i][6] == "")
                {
                    if (spielerGelb)
                    {
                        spielfeld[i][6] = "R";
                    }
                    else { spielfeld[i][6] = "G"; }
                    uebertrageArray();
                    return;
                }
            }
        }


        private void uebertrageArray()
        {
            if (spielfeld[0][0] == "G") { a1.BackColor = Color.Yellow; a1.Text = "G"; }
            if (spielfeld[1][0] == "G") { b1.BackColor = Color.Yellow; b1.Text = "G"; }
            if (spielfeld[2][0] == "G") { c1.BackColor = Color.Yellow; c1.Text = "G"; }
            if (spielfeld[3][0] == "G") { d1.BackColor = Color.Yellow; d1.Text = "G"; }
            if (spielfeld[4][0] == "G") { e1.BackColor = Color.Yellow; e1.Text = "G"; }
            if (spielfeld[5][0] == "G") { f1.BackColor = Color.Yellow; f1.Text = "G"; }

            if (spielfeld[0][0] == "R") { a1.BackColor = Color.Red; a1.Text = "R"; }
            if (spielfeld[1][0] == "R") { b1.BackColor = Color.Red; b1.Text = "R"; }
            if (spielfeld[2][0] == "R") { c1.BackColor = Color.Red; c1.Text = "R"; }
            if (spielfeld[3][0] == "R") { d1.BackColor = Color.Red; d1.Text = "R"; }
            if (spielfeld[4][0] == "R") { e1.BackColor = Color.Red; e1.Text = "R"; }
            if (spielfeld[5][0] == "R") { f1.BackColor = Color.Red; f1.Text = "R"; }

            if (spielfeld[0][1] == "G") { a2.BackColor = Color.Yellow; a2.Text = "G"; }
            if (spielfeld[1][1] == "G") { b2.BackColor = Color.Yellow; b2.Text = "G"; }
            if (spielfeld[2][1] == "G") { c2.BackColor = Color.Yellow; c2.Text = "G"; }
            if (spielfeld[3][1] == "G") { d2.BackColor = Color.Yellow; d2.Text = "G"; }
            if (spielfeld[4][1] == "G") { e2.BackColor = Color.Yellow; e2.Text = "G"; }
            if (spielfeld[5][1] == "G") { f2.BackColor = Color.Yellow; f2.Text = "G"; }

            if (spielfeld[0][1] == "R") { a2.BackColor = Color.Red; a2.Text = "R"; }
            if (spielfeld[1][1] == "R") { b2.BackColor = Color.Red; b2.Text = "R"; }
            if (spielfeld[2][1] == "R") { c2.BackColor = Color.Red; c2.Text = "R"; }
            if (spielfeld[3][1] == "R") { d2.BackColor = Color.Red; d2.Text = "R"; }
            if (spielfeld[4][1] == "R") { e2.BackColor = Color.Red; e2.Text = "R"; }
            if (spielfeld[5][1] == "R") { f2.BackColor = Color.Red; f2.Text = "R"; }

            if (spielfeld[0][2] == "G") { a3.BackColor = Color.Yellow; a3.Text = "G"; }
            if (spielfeld[1][2] == "G") { b3.BackColor = Color.Yellow; b3.Text = "G"; }
            if (spielfeld[2][2] == "G") { c3.BackColor = Color.Yellow; c3.Text = "G"; }
            if (spielfeld[3][2] == "G") { d3.BackColor = Color.Yellow; d3.Text = "G"; }
            if (spielfeld[4][2] == "G") { e3.BackColor = Color.Yellow; e3.Text = "G"; }
            if (spielfeld[5][2] == "G") { f3.BackColor = Color.Yellow; f3.Text = "G"; }

            if (spielfeld[0][2] == "R") { a3.BackColor = Color.Red; a3.Text = "R"; }
            if (spielfeld[1][2] == "R") { b3.BackColor = Color.Red; b3.Text = "R"; }
            if (spielfeld[2][2] == "R") { c3.BackColor = Color.Red; c3.Text = "R"; }
            if (spielfeld[3][2] == "R") { d3.BackColor = Color.Red; d3.Text = "R"; }
            if (spielfeld[4][2] == "R") { e3.BackColor = Color.Red; e3.Text = "R"; }
            if (spielfeld[5][2] == "R") { f3.BackColor = Color.Red; f3.Text = "R"; }
            //
            if (spielfeld[0][3] == "G") { a4.BackColor = Color.Yellow; a4.Text = "G"; }
            if (spielfeld[1][3] == "G") { b4.BackColor = Color.Yellow; b4.Text = "G"; }
            if (spielfeld[2][3] == "G") { c4.BackColor = Color.Yellow; c4.Text = "G"; }
            if (spielfeld[3][3] == "G") { d4.BackColor = Color.Yellow; d4.Text = "G"; }
            if (spielfeld[4][3] == "G") { e4.BackColor = Color.Yellow; e4.Text = "G"; }
            if (spielfeld[5][3] == "G") { f4.BackColor = Color.Yellow; f4.Text = "G"; }

            if (spielfeld[0][3] == "R") { a4.BackColor = Color.Red; a4.Text = "R"; }
            if (spielfeld[1][3] == "R") { b4.BackColor = Color.Red; b4.Text = "R"; }
            if (spielfeld[2][3] == "R") { c4.BackColor = Color.Red; c4.Text = "R"; }
            if (spielfeld[3][3] == "R") { d4.BackColor = Color.Red; d4.Text = "R"; }
            if (spielfeld[4][3] == "R") { e4.BackColor = Color.Red; e4.Text = "R"; }
            if (spielfeld[5][3] == "R") { f4.BackColor = Color.Red; f4.Text = "R"; }
            //Damit die Spieler mal wechseln
            if (spielfeld[0][4] == "G") { a5.BackColor = Color.Yellow; a5.Text = "G"; }
            if (spielfeld[1][4] == "G") { b5.BackColor = Color.Yellow; b5.Text = "G"; }
            if (spielfeld[2][4] == "G") { c5.BackColor = Color.Yellow; c5.Text = "G"; }
            if (spielfeld[3][4] == "G") { d5.BackColor = Color.Yellow; d5.Text = "G"; }
            if (spielfeld[4][4] == "G") { e5.BackColor = Color.Yellow; e5.Text = "G"; }
            if (spielfeld[5][4] == "G") { f5.BackColor = Color.Yellow; f5.Text = "G"; }

            if (spielfeld[0][4] == "R") { a5.BackColor = Color.Red; a5.Text = "R"; }
            if (spielfeld[1][4] == "R") { b5.BackColor = Color.Red; b5.Text = "R"; }
            if (spielfeld[2][4] == "R") { c5.BackColor = Color.Red; c5.Text = "R"; }
            if (spielfeld[3][4] == "R") { d5.BackColor = Color.Red; d5.Text = "R"; }
            if (spielfeld[4][4] == "R") { e5.BackColor = Color.Red; e5.Text = "R"; }
            if (spielfeld[5][4] == "R") { f5.BackColor = Color.Red; f5.Text = "R"; }
            // Spalte 6
            if (spielfeld[0][5] == "G") { a6.BackColor = Color.Yellow; a6.Text = "G"; }
            if (spielfeld[1][5] == "G") { b6.BackColor = Color.Yellow; b6.Text = "G"; }
            if (spielfeld[2][5] == "G") { c6.BackColor = Color.Yellow; c6.Text = "G"; }
            if (spielfeld[3][5] == "G") { d6.BackColor = Color.Yellow; d6.Text = "G"; }
            if (spielfeld[4][5] == "G") { e6.BackColor = Color.Yellow; e6.Text = "G"; }
            if (spielfeld[5][5] == "G") { f6.BackColor = Color.Yellow; f6.Text = "G"; }

            if (spielfeld[0][5] == "R") { a6.BackColor = Color.Red; a6.Text = "R"; }
            if (spielfeld[1][5] == "R") { b6.BackColor = Color.Red; b6.Text = "R"; }
            if (spielfeld[2][5] == "R") { c6.BackColor = Color.Red; c6.Text = "R"; }
            if (spielfeld[3][5] == "R") { d6.BackColor = Color.Red; d6.Text = "R"; }
            if (spielfeld[4][5] == "R") { e6.BackColor = Color.Red; e6.Text = "R"; }
            if (spielfeld[5][5] == "R") { f6.BackColor = Color.Red; f6.Text = "R"; }

            // Spalte 7
            if (spielfeld[0][6] == "G") { a7.BackColor = Color.Yellow; a7.Text = "G"; }
            if (spielfeld[1][6] == "G") { b7.BackColor = Color.Yellow; b7.Text = "G"; }
            if (spielfeld[2][6] == "G") { c7.BackColor = Color.Yellow; c7.Text = "G"; }
            if (spielfeld[3][6] == "G") { d7.BackColor = Color.Yellow; d7.Text = "G"; }
            if (spielfeld[4][6] == "G") { e7.BackColor = Color.Yellow; e7.Text = "G"; }
            if (spielfeld[5][6] == "G") { f7.BackColor = Color.Yellow; f7.Text = "G"; }

            if (spielfeld[0][6] == "R") { a7.BackColor = Color.Red; a7.Text = "R"; }
            if (spielfeld[1][6] == "R") { b7.BackColor = Color.Red; b7.Text = "R"; }
            if (spielfeld[2][6] == "R") { c7.BackColor = Color.Red; c7.Text = "R"; }
            if (spielfeld[3][6] == "R") { d7.BackColor = Color.Red; d7.Text = "R"; }
            if (spielfeld[4][6] == "R") { e7.BackColor = Color.Red; e7.Text = "R"; }
            if (spielfeld[5][6] == "R") { f7.BackColor = Color.Red; f7.Text = "R"; }

            if (spielerGelb)
            {
                textBox.Text = "   Spieler Gelb ist dran!"; textBox.BackColor = Color.Yellow;
                spielerGelb = !spielerGelb;
            }
            else { textBox.Text = "   Spieler Rot ist dran!"; textBox.BackColor = Color.Red; spielerGelb = !spielerGelb; }

           // Thread.Sleep(1000);
            prüfeArray();
        }

        private void b1_Click(object sender, EventArgs e)
        {
            fuerEins();
        }

        private void c1_Click(object sender, EventArgs e)
        {
            fuerEins();
        }

        private void d1_Click(object sender, EventArgs e)
        {
            fuerEins();
        }

        private void e1_Click(object sender, EventArgs e)
        {
            fuerEins();
        }

        private void f1_Click(object sender, EventArgs e)
        {
            fuerEins();
        }

        private void a2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void b2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void c2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void d2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void e2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void f2_Click(object sender, EventArgs e)
        {
            fuerZwei();
        }

        private void a3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void b3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void c3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void d3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void e3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void f3_Click(object sender, EventArgs e)
        {
            fuerDrei();
        }

        private void a4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void b4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void c4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void d4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void e4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void f4_Click(object sender, EventArgs e)
        {
            fuerVier();
        }

        private void a5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void b5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void c5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void d5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void e5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void f5_Click(object sender, EventArgs e)
        {
            fuerFunf();
        }

        private void b6_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        private void c6_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        private void d6_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        private void e6_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        private void f6_Click(object sender, EventArgs e)
        {
            fuerSechs();
        }

        private void a7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void b7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void c7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void d7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void e7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void f7_Click(object sender, EventArgs e)
        {
            fuerSiebn();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            computer = !computer;
            if (!computer) { textBox.Text = "   Derr Computer wurde ausgeschaltet"; }
            if (computer) { textBox.Text = "   Derr Computer wurde eingeschaltet"; }
        }
    }
}
