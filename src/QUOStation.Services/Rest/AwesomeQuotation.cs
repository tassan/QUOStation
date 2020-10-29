using QUOStation.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using RestSharp;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace QUOStation.Services.Rest
{
    public class AwesomeQuotation : IAwesomeQuotation
    {
        private readonly IConfiguration _configuration;

        public AwesomeQuotation(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public Dictionary<string, Currency> GetQuotation()
        {
            throw new NotImplementedException();
        }

        public Dictionary<string, Currency> GetQuotation(string currencies)
        {
            string baseUrl = $"{_configuration["AwesomeApi:BaseUrl"]}/all/{currencies}";

            RestRequest req = new RestRequest(baseUrl, DataFormat.Json);
            string res = new RestClient().Get(req).Content;

            return JsonConvert.DeserializeObject<Dictionary<string, Currency>>(res);
        }

        public Currency GetQuotation(string currency, int? days)
        {
            throw new NotImplementedException();
        }

        public Currency GetQuotation(string currency, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }

        public Currency GetQuotation(string currency, dynamic quantity)
        {
            throw new NotImplementedException();
        }

        public Currency GetQuotation(string currency, dynamic quantity, string startDate, string endDate)
        {
            throw new NotImplementedException();
        }
    }
}
