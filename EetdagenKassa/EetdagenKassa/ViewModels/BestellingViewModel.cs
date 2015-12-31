using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace EetdagenKassa.ViewModels
{
    public class BestellingViewModel
    {
        public Guid Id { get; set; }
        public Models.Bestelling.Periode Shift { get; set; }
        public Models.Kassa Kassanr { get; set;  }
        public float Totaal { get; set; }
        public int Bonnen { get; set; }
        public Boolean Contant { get; set; }
        public Boolean Bancontact { get; set; }

        public virtual ICollection<Models.Gerecht> Gerechts { get; set; }
 
    }
}