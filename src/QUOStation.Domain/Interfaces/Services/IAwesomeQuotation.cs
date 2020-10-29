using System;
using System.Collections.Generic;
using System.Text;

namespace QUOStation.Domain.Interfaces.Services
{
    public interface IAwesomeQuotation<T>
    {
        T GetQuotation();
        T GetQuotation(string[] currencies);
        T GetQuotation(string currency, int? days);
        T GetQuotation(string currency, string startDate, string endDate);
        T GetQuotation(string currency, dynamic quantity);
        T GetQuotation(string currency, dynamic quantity, string startDate, string endDate);
    }
}
