using Infrastruktur.Clients;
using System.Drawing;
using System.Windows.Forms;

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
                var bildBox = new PictureBox();
                flowLayoutPanel1.Controls.Add(bildBox);
                bildBox.Load(produkt.BildWeb90.AbsoluteUri);
                bildBox.Size = new Size(100, 100);
                bildBox.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}