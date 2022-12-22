
using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceRepositories

{

    public class InvoiceRepository : IInvoiceRepository
    {

        IQueryable<Invoice> _invoices;
        public InvoiceRepository(IQueryable<Invoice> invoices)
        {
            // Console.WriteLine("Sample debug output");
            this._invoices = invoices;
        }

        /// <summary>
        /// Should return a total value of an invoice with a given id. If an invoice does not exist null should be returned.
        /// </summary>
        /// <param name="invoiceId"></param>
        /// <returns></returns>
        public decimal? GetTotal(int invoiceId)
        {
            try
            {
                decimal? total;
                total = _invoices.Where(std => std.Id == invoiceId).Sum(std => std.InvoiceItems.Sum(x => x.Price));
                return (total <= 0 ? null : total);
            }
            catch (Exception ex)
            {
                //Exception can be logged and a custom message can be returned.
                throw;
            }
        }

        /// <summary>
        /// Should return a total value of all unpaid invoices.
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalOfUnpaid()
        {
            decimal total = 0;
            try
            {
                total = _invoices.Where(std => std.AcceptanceDate == null).Sum(std => std.InvoiceItems.Sum(x => x.Price));
            }
            catch (Exception ex)
            {
                //Exception can be logged and a custom message can be returned.
                throw;
            }
            return total;
        }

        /// <summary>
        /// Should return a dictionary where the name of an invoice item is a key and the number of bought items is a value.
        /// The number of bought items should be summed within a given period of time (from, to). Both the from date and the end date can be null.
        /// </summary>
        /// <param name="from"></param>
        /// <param name="to"></param>
        /// <returns></returns>
        public IReadOnlyDictionary<string, long> GetItemsReport(DateTime? from, DateTime? to)
        {
            Dictionary<string, long> dic = new Dictionary<string, long>();

            try
            {
                //from =null then result null
                //to=null then result null. if we need the result we need to remove the from, from the query list and then it can return an answer (foreach (var invoice in _invoices.Where(x => x.CreationDate <= to))).
                //from =null and to=null then result null
                //from =value and to=value then result

                foreach (var invoice in _invoices
                    .Where((x => x.CreationDate >= from && x.CreationDate <= to))
                    )
                {
                    foreach (var ini in invoice.InvoiceItems)
                    {
                        var thisValue = dic.FirstOrDefault(t => t.Key == ini.Name);
                        var tot = thisValue.Value + ini.Count;
                        dic.Remove(ini.Name);
                        dic.Add(ini.Name, tot);
                    }
                }

                return dic;
            }
            catch (Exception ex)
            {
                //Exception can be logged and a custom message can be returned.
                throw;
            }
        }

        public IReadOnlyDictionary<string, long> GetItemsReportNew(DateTime? from, DateTime? to)
        {
            Dictionary<string, long> dic = new Dictionary<string, long>();
            
            try
            {
                //from =null then result null
                //to=null then result null. if we need the result we need to remove the from, from the query list and then it can return an answer (foreach (var invoice in _invoices.Where(x => x.CreationDate <= to))).
                //from =null and to=null then result null
                //from =value and to=value then result

                if (from != null && to != null)
                {
                    foreach (var invoice in _invoices
                        .Where((x => x.CreationDate >= from && x.CreationDate <= to)))
                    {
                        foreach (var ini in invoice.InvoiceItems)
                        {
                            var thisValue = dic.FirstOrDefault(t => t.Key == ini.Name);
                            var tot = thisValue.Value + ini.Count;
                            dic.Remove(ini.Name);
                            dic.Add(ini.Name, tot);
                        }
                    }
                }

                else if (from != null && to == null)
                {
                    foreach (var invoice in _invoices
                        .Where((x => x.CreationDate >= from )))
                    {
                        foreach (var ini in invoice.InvoiceItems)
                        {
                            var thisValue = dic.FirstOrDefault(t => t.Key == ini.Name);
                            var tot = thisValue.Value + ini.Count;
                            dic.Remove(ini.Name);
                            dic.Add(ini.Name, tot);
                        }
                    }
                }
                else
                {
                    foreach (var invoice in _invoices
                    .Where((x =>  x.CreationDate <= to)))
                    {
                        {
                            foreach (var ini in invoice.InvoiceItems)
                            {
                                var thisValue = dic.FirstOrDefault(t => t.Key == ini.Name);
                                var tot = thisValue.Value + ini.Count;
                                dic.Remove(ini.Name);
                                dic.Add(ini.Name, tot);
                            }
                        }
                    }
                }
                return dic;
            }
            catch (Exception ex)
            {
                //Exception can be logged and a custom message can be returned.
                throw;
            }
        }
    }
}
