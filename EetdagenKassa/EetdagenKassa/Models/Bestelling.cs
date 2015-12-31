using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EetdagenKassa.Models
{
    public class Bestelling
    {
        public enum Periode
        {
            Zaterdag,
            Zondagmiddag, 
            Zondagavond
        }

        // ? bij periode en  kassa = nullable

        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid BestellingID { get; set; } 
        public Periode? Shift { get; set; }
        public Kassa? Kassa { get; set; }
        public float TotaalPrijs { get; set; }
        public int Bonnen { get; set; }
        public Boolean Contant { get; set; }
        public Boolean Bancontact { get; set; }
        public ICollection <Gerecht> Gerechts { get; set; }

        public Bestelling() { BestellingID = Guid.NewGuid(); }
    }

    
}