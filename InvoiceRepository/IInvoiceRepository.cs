using System;
using System.Collections.Generic;
using System.Text;

namespace InvoiceRepositories
{
    public interface IInvoiceRepository
    {
        public decimal? GetTotal(int invoiceId);
        public decimal GetTotalOfUnpaid();
        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to);
    }
}
