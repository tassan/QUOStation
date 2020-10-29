using System.Collections.Generic;

namespace QUOStation.Domain.Interfaces.Services
{
    public interface IAwesomeQuotation
    {
        public Dictionary<string, Currency> GetQuotation();
        public Dictionary<string, Currency> GetQuotation(string currencies);
        public Currency GetQuotation(string currency, int? days);
        public Currency GetQuotation(string currency, string startDate, string endDate);
        public Currency GetQuotation(string currency, dynamic quantity);
        public Currency GetQuotation(string currency, dynamic quantity, string startDate, string endDate);
    }
}
