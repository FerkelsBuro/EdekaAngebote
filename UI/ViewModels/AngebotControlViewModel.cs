using Domain.Models;

namespace UI.ViewModels
{
    public class AngebotControlViewModel
    {
        public AngebotControlViewModel(string bildUrl, string titel, double preis)
        {
            BildUrl = bildUrl;
            Titel = titel;
            Preis = preis;
        }

        public AngebotControlViewModel(Produkt produkt)
        {
            BildUrl = produkt.BildWeb130.AbsoluteUri;
            Preis = produkt.Preis;
            Titel = produkt.Titel;
        }

        public string BildUrl { get; set; }
        public string Titel { get; set; }
        public double Preis { get; set; }
    }
}