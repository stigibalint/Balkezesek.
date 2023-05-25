using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balkezesek
{
    public class BalkezesekClass
    {
        string Nev;
        string elsoDatum;
        string utolsoDatum;
        int jatekosSulya;
        int jatekosMagassag;

        public BalkezesekClass(string nev, string elsoDatum, string utolsoDatum, int jatekosSulya, int jatekosMagassag)
        {
            this.Nev = nev;
            this.ElsoDatum = elsoDatum;
            this.UtolsoDatum = utolsoDatum;
            this.JatekosSulya = jatekosSulya;
            this.JatekosMagassag = jatekosMagassag;
        }
        public BalkezesekClass(string CSVSorok)
        {
            var mezo = CSVSorok.Split(";");
            this.Nev = mezo[0];
            this.elsoDatum = mezo[1];
            this.utolsoDatum = mezo[2];
            this.jatekosSulya = int.Parse(mezo[3]);
            this.jatekosMagassag = int.Parse(mezo[4]);
        }
        public string Nev1 { get => Nev; set => Nev = value; }
        public string ElsoDatum { get => elsoDatum; set => elsoDatum = value; }
        public string UtolsoDatum { get => utolsoDatum; set => utolsoDatum = value; }
        public int JatekosSulya { get => jatekosSulya; set => jatekosSulya = value; }
        public int JatekosMagassag { get => jatekosMagassag; set => jatekosMagassag = value; }
    }
}
