using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Models;

namespace UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            var client = new RestClient("https://www.edeka.de");

            var request = new RestRequest("/eh/service/eh/offers?marketId=8000973&limit=8", DataFormat.Json);

            var response = client.Get<Angebot>(request);

            pictureBox1.Load(response.Data.Docs.ElementAt(0).BildWeb90.AbsoluteUri);
        }

    }
}
