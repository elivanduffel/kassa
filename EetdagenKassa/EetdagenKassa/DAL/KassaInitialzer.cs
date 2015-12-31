using System.Collections.Generic;
using EetdagenKassa.Models;
using System.Linq;

namespace EetdagenKassa.DAL
{
    public class KassaInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<KassaContext>
    {
        protected override void Seed(KassaContext context)

        { }

            public Gerecht GetGerechts(int ID)
        {
            var gerechts = GetList();
            return (from p in gerechts where (p.GerechtID == ID) select p).FirstOrDefault();
        } 

        public List<Gerecht> GetFullList()
        {
            var gerechts = GetList();
            return (from p in gerechts select p).OrderBy(p => p.GerechtID).ToList();
        }

        public List<Gerecht> GetList() {
            var gerechts = new List<Gerecht>
            {
            new Gerecht { GerechtID = 1 , Omschrijving = "Voorgerecht", Prijs = 5 },
            new Gerecht { GerechtID = 2 ,Omschrijving = "Biefstuk Champignon", Prijs = 15 },
            new Gerecht { GerechtID = 3 , Omschrijving = "Biefstuk Provençale", Prijs = 15 },
            new Gerecht { GerechtID = 4 ,Omschrijving = "Biefstuk Vleessaus", Prijs = 15 },
            new Gerecht { GerechtID = 5 ,Omschrijving = "Biefstuk zonder saus", Prijs = 15 },

            new Gerecht { GerechtID = 6 ,Omschrijving = "Filet Champignon", Prijs = 12 },
            new Gerecht { GerechtID = 7 ,Omschrijving = "Filet Provençale", Prijs = 12 },
            new Gerecht { GerechtID = 8 , Omschrijving = "Filet zonder saus", Prijs = 12 },

            new Gerecht { GerechtID = 9 ,Omschrijving = "Vegetarische burger Champignon", Prijs = 12 },
            new Gerecht { GerechtID = 10 ,Omschrijving = "Vegetarische burger Provençale", Prijs = 12 },
            new Gerecht { GerechtID = 11,Omschrijving = "Vegetarische zonder saus", Prijs = 12 },

            new Gerecht { GerechtID = 12 ,Omschrijving = "Vol au vent", Prijs = 12 },
            new Gerecht { GerechtID = 13 ,Omschrijving = "Kindermenu", Prijs = 8 },

            new Gerecht { GerechtID = 14 , Omschrijving = "Vacqueyras  (fles)", Prijs = 18 },
            new Gerecht { GerechtID = 15 ,Omschrijving = "Château La Courolle  (fles)", Prijs = 16 },
            new Gerecht { GerechtID = 16 ,Omschrijving = "Maurel Merlot  (fles)", Prijs = 12 },
            new Gerecht { GerechtID = 17 ,Omschrijving = "Maurel Merlot  (glas)", Prijs = 2.5f },
            new Gerecht { GerechtID = 18 , Omschrijving = "Fontenelles  (fles)", Prijs = 12 },
            new Gerecht { GerechtID = 19 ,Omschrijving = "Fontenelles  (glas)", Prijs = 2.5f },

            new Gerecht { GerechtID = 20 ,Omschrijving = "Pils", Prijs = 1.7f },
            new Gerecht { GerechtID = 21 ,Omschrijving = "Water Bruis (glas)", Prijs = 1.7f },
            new Gerecht { GerechtID = 22 ,Omschrijving = "Water Bruis (fles)", Prijs = 6 },
            new Gerecht { GerechtID = 23 ,Omschrijving = "Water Plat (glas)", Prijs = 1.7f },
            new Gerecht { GerechtID = 24 ,Omschrijving = "Water Plat (fles)", Prijs = 6 },
            new Gerecht { GerechtID = 25,Omschrijving = "Cola", Prijs = 1.7f },
            new Gerecht { GerechtID = 26 , Omschrijving = "Limo", Prijs = 1.7f },
            new Gerecht { GerechtID = 27 ,Omschrijving = "Koffie filter", Prijs = 1.7f },
            new Gerecht { GerechtID = 28 , Omschrijving = "Koffie deca", Prijs = 1.7f },
            new Gerecht { GerechtID = 29 , Omschrijving = "Thee", Prijs = 1.7f }


            };
            return gerechts;
        }
    }

        
    }
    