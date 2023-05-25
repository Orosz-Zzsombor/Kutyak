using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    internal class KutyaNevek
    {
        int id;
        string kutyanev;


        public KutyaNevek(string CSVsor) 
        {
            var mezo = CSVsor.Split(";");
            this.id = int.Parse(mezo[0]);
            this.kutyanev = mezo[1];
        }
        public KutyaNevek(int id, string kutyanev)
        {
            this.id = id;
            this.kutyanev = kutyanev;
        }

        public int Id { get => id; set => id = value; }
        public string Kutyanev { get => kutyanev; set => kutyanev = value; }
    }
}
