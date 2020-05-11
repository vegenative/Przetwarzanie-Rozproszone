using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozproszoneZajecia.encje
{
    public class Dziecko
	{
        
		public int Id { get; set; }
		public string Imie { get; set; }
		public string Nazwisko { get; set; }
		public int Wiek { get; set; }

		public virtual Zestaw zestawy { get; set; }

		
	
	}
}
