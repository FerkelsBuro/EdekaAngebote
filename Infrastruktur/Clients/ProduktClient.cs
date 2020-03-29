﻿using Domain.Models;
using RestSharp;

namespace Infrastruktur.Clients
{
    public class ProduktClient
    {
        private readonly RestClient client;

        public ProduktClient()
        {
            client = new RestClient("https://www.edeka.de");
        }

        public Angebot GetAngebot()
        {
            var request = new RestRequest("/eh/service/eh/offers?marketId=8000973&limit=8", DataFormat.Json);

            var response = client.Get<Angebot>(request);

            return response.Data;
        }
    }
}