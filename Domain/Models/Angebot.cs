using System.Collections.Generic;

namespace Domain.Models
{
    public class Angebot
    {
        public IEnumerable<Produkt> Docs { get; set; }
        public long Anzahl { get; set; }
        public long GueltigVon { get; set; }
        public long GueltigBis { get; set; }
        public long LastModified { get; set; }
        public bool National { get; set; }
    }
}