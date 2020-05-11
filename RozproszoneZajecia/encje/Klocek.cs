using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozproszoneZajecia.encje
{
    public class Klocek
	{
        
		public int Id { get; set; }
		public int Ilosc { get; set; }
		public virtual Zestaw zestawy { get; set; }
		public virtual int zestawId { get; set; }


}
}
