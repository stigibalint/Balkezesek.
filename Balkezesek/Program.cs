using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Balkezesek;

List<BalkezesekClass> adatok = new List<BalkezesekClass>();
try
{
    File.ReadAllLines("balkezesek.csv").Skip(1).ToList().ForEach(x => adatok.Add(new BalkezesekClass(x)));
}
catch (IOException e)
{
    Console.WriteLine($"Hiba történt a fájl olvasása közben: {e.Message}");
}
Console.WriteLine($"3. feladat: {adatok.Count}");

var jatekosok1999Oktober = adatok.Where(j => j.UtolsoDatum.Contains("1999-10"));

Console.WriteLine("4. feladat:");
foreach (var jatekos in jatekosok1999Oktober)
{
    double magassagCm = jatekos.JatekosMagassag * 2.54;
    Console.WriteLine($"{jatekos.Nev1} {magassagCm}".PadLeft(20));
}

Console.WriteLine("5. feladat: ");
int evszam = int.Parse(Console.ReadLine());
do
{
    if (!(evszam >= 1990 && evszam <= 1999))
    {
        Console.WriteLine($"Hibás adat!Kérek egy 1990 és 1999 közötti évszámot!: {evszam}");
        evszam = int.Parse(Console.ReadLine());
    }
    else
    {
        int jatekosokSzama = adatok.Count(j => j.ElsoDatum.StartsWith(evszam.ToString()) || j.UtolsoDatum.StartsWith(evszam.ToString()));
        Console.WriteLine("Az {0}. évben {1} játékos játszott.", evszam, jatekosokSzama);
        break;
    }
} while (true);


var atlagosSuly = adatok.Where(j => j.ElsoDatum.StartsWith(evszam.ToString()) || j.UtolsoDatum.StartsWith(evszam.ToString())).Select(j => j.JatekosSulya).Average();
Console.WriteLine($"6. feladat:{Math.Round(atlagosSuly,2)} ");