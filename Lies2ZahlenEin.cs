using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.IO;


    
        Console.WriteLine("Erste Zahl:");
        int zahl1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Zweite Zahl:");
        int zahl2 = Convert.ToInt32(Console.ReadLine());

        if (zahl1 > zahl2)
        {
            Console.WriteLine("Die erste Zahl ist größer: " + zahl1);
        }
        else
        {
            Console.WriteLine("Die zweite Zahl ist größer oder gleich groß: " + zahl2);
        }

//this.Close();
System.Environment.Exit(1);



