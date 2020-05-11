using RozproszoneZajecia.encje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RozproszoneZajecia
{
	public class DodajDzieci
	{
		private DzieckoContext dzieckoContext;

		public DodajDzieci(DzieckoContext dzieckoContext)
		{
			this.dzieckoContext = dzieckoContext;
		}

		public void DodajDane()
		{
			if (dzieckoContext.Database.CanConnect())
			{
				if (!dzieckoContext.dzieci.Any())
				{
					WstawRekordy();
				}
			}
		}

		private void WstawRekordy()
		{
			var dzieci = new List<Dziecko>
			{
				new Dziecko
				{
					Imie = "Małgosia",
					Nazwisko = "Kowalska",
					Wiek = 6,


					zestawy = new Zestaw
					{
						Opis="Dom dla lalek",
						Wielkość=40,
						Cena=49.99f,
					

						klocki = new List<Klocek>
						{
							new Klocek
							{
								Ilosc = 256,
							},
							new Klocek
							{
								Ilosc = 300,
							}
						}


					},
				},
				new Dziecko
				{
					Imie = "Franek",
					Nazwisko = "Psikuta",
					Wiek = 2,


					zestawy = new Zestaw
					{
						Opis="Wóz stażacki",
						Wielkość=100,
						Cena=69.99f,

						klocki = new List<Klocek>
						{
							new Klocek
							{
								Ilosc = 10,
							}

						}

					},
				},
				new Dziecko
				{
					Imie = "Zbysiu",
					Nazwisko = "Szaman",
					Wiek = 5,


					zestawy = new Zestaw
					{
						Opis="Lego",
						Wielkość=25,
						Cena=19.99f,


						klocki = new List<Klocek>
						{
							new Klocek
							{
								Ilosc = 24,
							},
							new Klocek
							{
								Ilosc = 45,
							}
						}


					},
				},


			};
			dzieckoContext.AddRange(dzieci);
			dzieckoContext.SaveChanges();
		}
	}
}
