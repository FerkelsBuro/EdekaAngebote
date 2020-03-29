using Infrastruktur.Clients;
using System.Windows.Forms;
using UI.ViewModels;

namespace UI
{
    public partial class Form1 : Form
    {
        private IProduktClient _client;

        public Form1(IProduktClient client)
        {
            InitializeComponent();

            _client = client;

            Init();
        }

        private void Init()
        {
            var angebot = _client.GetAngebot();
            foreach (var produkt in angebot.Docs)
            {
                var viewModel = new AngebotControlViewModel(produkt);
                var angebotControl = new AngebotControl(viewModel);

                flowLayoutPanel1.Controls.Add(angebotControl);
            }
        }
    }
}