using System;
using System.IO;

Console.WriteLine("Hello, World!");
Console.WriteLine("Willkommen im Taschenrechner. Gib deine Rechnung an");
double loesung = 0;
string s1 = Convert.ToString(Console.ReadLine());

//string helloWorld = "Hello, world!";
//string s1 = "The quick brown fox jumps over the lazy dog";
string plus = "+";
bool bplus = s1.Contains(plus);
string minus = "-";
bool bminus = s1.Contains(minus);
string mal = "*";
bool bmal = s1.Contains(mal);
string gete = "/";
bool bgete = s1.Contains(gete);

if (bgete) {
    string[] subs = s1.Split('/');
    double[] subsDouble = new double[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        subsDouble[i] = Convert.ToDouble(subs[i]);
    }
    for (int i = 0; i < subsDouble.Length - 1; i++)
    {
        loesung = subsDouble[i] / subsDouble[i + 1];
    }
}
if (bmal) {
    string[] subs = s1.Split('*');
    double[] subsDouble = new double[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        subsDouble[i] = Convert.ToDouble(subs[i]);
    }
    for (int i = 0; i < subsDouble.Length - 1; i++)
    {
        loesung = subsDouble[i] * subsDouble[i + 1];
    }
}   
if  (bminus) {
    string[] subs = s1.Split('-');
    double[] subsDouble = new double[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        subsDouble[i] = Convert.ToDouble(subs[i]);
    }
    for (int i = 0; i < subsDouble.Length-1; i++)
    {
        loesung = subsDouble[i] - subsDouble[i+1];
    }
}
if (bplus) {
    string[] subs = s1.Split('+');
    double[] subsDouble = new double[subs.Length];
    for (int i = 0; i < subs.Length; i++)
    {
        subsDouble[i] = Convert.ToDouble(subs[i]);
    }
    for (int i = 0; i < subsDouble.Length; i++)
    {
        loesung = subsDouble[i] + loesung;
    }
}

Console.WriteLine("Die Lösung lautet " + loesung);
Console.WriteLine(" ");
Console.WriteLine("");