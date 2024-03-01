using System;
using System.IO;
using System.Collections;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string loesung= "";

//String[] zeile = new string[];
String line;
ArrayList arlist = new ArrayList();


try
{
    //Pass the file path and file name to the StreamReader constructor
    StreamReader sr = new StreamReader("C:\\segment-2.txt");
    //Read the first line of text
    line = sr.ReadLine();
    arlist.Add(line);
    //Continue to read until you reach end of file
   
    while (line != null)
    {
        //write the line to console window
        Console.WriteLine(line);
        //Read the next line
        line = sr.ReadLine();
        arlist.Add(line);
    }
    
    sr.Close();

    /* Console.WriteLine("test");
     Console.WriteLine("test");
     Console.WriteLine("test");
     //Console.WriteLine((string)arlist[0]);
     Console.WriteLine((string)arlist[1]);
     Console.WriteLine((string)arlist[2]);*/
    int l = arlist.Count;
    for (int k = 0; k < l-2; k++) { 

    string s1 = ((string)arlist[k]);
    char[] chars1 = s1.ToCharArray();

    string s2 = ((string)arlist[k+1]);
    char[] chars2 = s2.ToCharArray();

    string s3 = ((string)arlist[k+2]);
    char[] chars3 = s3.ToCharArray();

    for (int i = 0; i < s1.Length-2; i++) {
        ///////////////////////////////Fuer 2 
        if (  chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] ==' '
            && chars2[i] == ' ' && chars2[i + 1] == '_' && chars2[i + 2] == '|'
            && chars3[i] == '|' && chars3[i + 1] == '_' && chars3[i + 2] == ' '
             ) {
             loesung = loesung + "2";
         }
         ////////////////////////////////// Fuer 1
        if ( chars1[i] == ' ' && chars1[i + 1] == ' ' &&  chars1[i + 2] == ' '
          && chars2[i] == ' ' && chars2[i + 1] == ' ' && chars2[i + 2] == '|'
          && chars3[i] == ' ' && chars3[i + 1] == ' ' && chars3[i + 2] == '|'
           ){
            loesung = loesung + "1";
        }
        /////////////////////////Fuer 3
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == ' ' && chars2[i + 1] == '_' && chars2[i + 2] == '|'
          && chars3[i] == ' ' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "3";
        }
        /////////////////////////Fuer 4
        if (chars1[i] == ' ' && chars1[i + 1] == ' ' && chars1[i + 2] == ' '
          && chars2[i] == '|' && chars2[i + 1] == '_' && chars2[i + 2] == '|'
          && chars3[i] == ' ' && chars3[i + 1] == ' ' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "4";
        }
        ////////////////////////////////// Fuer 5
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == '|' && chars2[i + 1] == '_' && chars2[i + 2] == ' '
          && chars3[i] == ' ' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "5";
        }
        ////////////////////////////////// Fuer 6
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == '|' && chars2[i + 1] == '_' && chars2[i + 2] == ' '
          && chars3[i] == '|' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "6";
        }
        ////////////////////////////////// Fuer 1
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == ' ' && chars2[i + 1] == ' ' && chars2[i + 2] == '|'
          && chars3[i] == ' ' && chars3[i + 1] == ' ' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "7";
        }

        ////////////////////////////////// Fuer 8
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == '|' && chars2[i + 1] == '_' && chars2[i + 2] == '|'
          && chars3[i] == '|' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "8";
        }

        ////////////////////////////////// Fuer 9
        if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
          && chars2[i] == '|' && chars2[i + 1] == '_' && chars2[i + 2] == '|'
          && chars3[i] == ' ' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
           )
        {
            loesung = loesung + "9";
            }
        ////////////////////////////////// Fuer 0
            if (chars1[i] == ' ' && chars1[i + 1] == '_' && chars1[i + 2] == ' '
              && chars2[i] == '|' && chars2[i + 1] == ' ' && chars2[i + 2] == '|'
              && chars3[i] == '|' && chars3[i + 1] == '_' && chars3[i + 2] == '|'
               )
            {
                loesung = loesung + "0";
            }
            // War fürs Debugging gut
           /* Console.WriteLine(chars1[i] +""+   chars1[i + 1] + "" + chars1[i + 2]);
            Console.WriteLine(chars2[i] + "" + chars2[i + 1] + "" + chars2[i + 2]);
            Console.WriteLine(chars3[i] + "" + chars3[i + 1] + "" + chars3[i + 2]);
            Console.WriteLine("nächsteZeile");
            Console.WriteLine(loesung);
            Console.WriteLine("dies ist die Loesung");*/

        }
        loesung = loesung + " ";
      //  Console.WriteLine("nächste Zeile");
      //  Console.WriteLine(loesung);

    }



    Console.WriteLine(" ");
    Console.WriteLine(" ");
    Console.WriteLine(loesung);
    Console.WriteLine("Dies ist die Loesung");

    /*
    string s = "AaBbCcDd";
    char[] chars = s.ToCharArray();
    Console.WriteLine("Original string: {0}", s);
    Console.WriteLine("Character array:");
    for (int ctr = 0; ctr < chars.Length; ctr++)
    {
        Console.WriteLine(  chars[ctr]);
    }
*/
    Console.ReadLine();
    

    
}




//Fehler? Nein Danke   (:
catch (Exception e)
{
    //Console.WriteLine("Exception: " + e.Message);
    Console.WriteLine(loesung);
}
finally
{
    //Console.WriteLine("Executing finally block.");
}