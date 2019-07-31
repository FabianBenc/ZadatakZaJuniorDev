using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imenik.Models
{
    public class Kontakti{
        public int id { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string grad { get; set; }
        public string opis { get; set; }
        public ICollection<Telefon> telefon { get; set; }
        public string slika { get; set; }
        //dodati sliku 
    }

    public class Telefon{
        public int id { get; set; }
        public int Kontaktiid { get; set; }
        public string broj { get; set; }
        public string tip { get; set; }
        public string opis { get; set; }
    }

}