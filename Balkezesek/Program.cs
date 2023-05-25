using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Balkezesek;

List<BalkezesekClass> adatok = new List<BalkezesekClass>();
try
{
    string[] sorok = File.ReadAllLines("balkezesek.csv");
    for (int i = 1; i < sorok.Length; i++)
    {
        adatok.Add(new BalkezesekClass(sorok[i]));
    }
}
catch (IOException e)
{
    Console.WriteLine($"Hiba történt a fájl olvasása közben: {e.Message}");
}
Console.WriteLine("3. feladat: A forrásállományban {0} adatsor található.", adatok.Count);
var jatekosok1999Oktober = adatok.Where(j => j.UtolsoDatum.EndsWith("1999-10"));
Console.WriteLine("4. feladat: :");
foreach (var jatekos in jatekosok1999Oktober)
{
    double magassagCm = jatekos.JatekosMagassag * 2.54;
    Console.WriteLine("Név: {0}, Magasság: {1:F1} cm", jatekos.Nev1, magassagCm);
}
Console.WriteLine("5. feladat: Kérem adjon meg egy évszámot (1990 és 1999 között):");
int evszam = int.Parse(Console.ReadLine());

while (true)
{
        if (evszam >= 1990 && evszam <= 1999)
            break;
   
    Console.WriteLine("Hibás évszám! Kérem adjon meg egy érvényes évszámot (1990 és 1999 között):");
}

int jatekosokSzama = adatok.Count(j => j.ElsoDatum.StartsWith(evszam.ToString()) || j.UtolsoDatum.StartsWith(evszam.ToString()));
Console.WriteLine("Az {0}. évben {1} játékos játszott.", evszam, jatekosokSzama);