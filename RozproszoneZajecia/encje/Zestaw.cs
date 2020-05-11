using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozproszoneZajecia.encje
{
    public class Zestaw
    {
        public int Id { get; set; }
        public string Opis { get; set; }
        public float Wielkość { get; set; }
        public float Cena { get; set; }

        

        public virtual Dziecko dzieci { get; set; }
        public virtual int dzieciId { get; set; }

        public virtual List<Klocek> klocki { get; set; }

        
    }
}
