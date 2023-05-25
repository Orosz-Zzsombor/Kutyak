using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kutyak
{
    internal class Kutyak
    {
        int id;
        int fajtaId;
        int nevId;
        int eletkor;
        int orvos;

        public Kutyak(string CSVsor)
        {
            var mezo = CSVsor.Split(" ");
            this.id = int.Parse(mezo[0]);
            this.fajtaId = int.Parse(mezo[1]);
            this.nevId = int.Parse(mezo[2]);
            this.eletkor = int.Parse(mezo[3]);
            this.orvos = int.Parse(mezo[4]);
        }
        public Kutyak(int id, int fajtaId, int nevId, int eletkor, int orvos)
        {
            this.id = id;
            this.fajtaId = fajtaId;
            this.nevId = nevId;
            this.eletkor = eletkor;
            this.orvos = orvos;
        }

        public int Id { get => id; set => id = value; }
        public int FajtaId { get => fajtaId; set => fajtaId = value; }
        public int NevId { get => nevId; set => nevId = value; }
        public int Eletkor { get => eletkor; set => eletkor = value; }
        public int Orvos { get => orvos; set => orvos = value; }
    }
}
