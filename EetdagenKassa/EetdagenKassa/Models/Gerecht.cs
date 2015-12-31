using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EetdagenKassa.Models
{
    public class Gerecht
    {
        public int GerechtID { get; set; }
        public String Omschrijving { get; set; }
        public float Prijs { get; set; }

        //public Gerecht() { GerechtID = Guid.NewGuid(); }
    }
}