using System;

namespace Domain.Models
{
    public class Produkt
    {
        public long Angebotid { get; set; }
        public object Externeid { get; set; }
        public string Titel { get; set; }
        public double Preis { get; set; }
        public string Beschreibung { get; set; }
        public long PunkteDeutschlandcard { get; set; }
        public object Zusatztext { get; set; }
        public Uri BildWeb90 { get; set; }
        public Uri BildWeb130 { get; set; }
        public Uri BildApp { get; set; }
        public object Warengruppe { get; set; }
        public object Warengruppeid { get; set; }
        public object Kriterien { get; set; }
        public object Sonderkennzeichen { get; set; }
        public object Zutaten { get; set; }
        public object Nachlass { get; set; }
        public object Genussplus { get; set; }
        public string BasicPrice { get; set; }
        public bool National { get; set; }
        public long GueltigBis { get; set; }
    }
}