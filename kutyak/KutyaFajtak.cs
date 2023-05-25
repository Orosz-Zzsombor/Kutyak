using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    internal class KutyaFajtak
    {
        int id;
        string nev;
        string eredetiNev;

        public KutyaFajtak(string CSVsor)
        {
            var mezo = CSVsor.Split(" ");
            this.id = int.Parse(mezo[0]);
            this.nev = mezo[1];
            this.eredetiNev= mezo[2];
        }
        public KutyaFajtak(int id, string nev, string eredetiNev)
        {
            this.id = id;
            this.nev = nev;
            this.eredetiNev = eredetiNev;
        }

        public int Id { get => id; set => id = value; }
        public string Nev { get => nev; set => nev = value; }
        public string EredetiNev { get => eredetiNev; set => eredetiNev = value; }
    }
}
