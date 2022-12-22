using InvoiceTest;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using InvoiceRepositories;

namespace TestProject
{
    [TestClass]
    public class InvoiceRepositoryTest
    {

        IQueryable<Invoice> _invoices;
        IQueryable<Invoice> _invoices1;
        public InvoiceRepositoryTest()
        {
            this._invoices = Data.GetData().AsQueryable();
            this._invoices1 = Data.GetData1().AsQueryable();
        }

        [TestMethod]
        public void GetTotal_NoInvoices_NullShouldBeReturned1()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(1234567896);

            Assert.AreEqual( null, result);
        }

        [TestMethod]
        public void Constructor_NullInputParameter_ExceptionShouldBeThrown()
        {
            try
            {
                InvoiceRepository invRepo = new InvoiceRepository(null);
                decimal? result = invRepo.GetTotal(1234567896);
                Assert.Fail();
            }
            catch (Exception ex)
            {
                Assert.AreEqual( "Value cannot be null. (Parameter 'source')", ex.Message);
            }
        }

        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned1()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(1);
            Assert.AreEqual(110,result);
        }

        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned7()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(-1234567896);
            Assert.AreEqual(null, result);
        }

        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned2()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(50000);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned3()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(124578963);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned5()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(-1);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned6()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices1);
            decimal? result = invRepo.GetTotal(-1);
            Assert.AreEqual(110, result);
        }

        [TestMethod]
        public void GetTotal_NoInvoices_NullShouldBeReturned()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices1);
            decimal? result = invRepo.GetTotal(4);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetItemsReport_InvoicesExist_CorrectReportShouldBeReturned3()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReport(new DateTime(2018, 5, 1, 0, 0, 0), new DateTime(2018, 5, 16, 23, 59, 59));
            Assert.AreEqual(10, dic.Count);
        }
        [TestMethod]
        public void GetItemsReport_NoInvoices_EmptyReportShouldBeReturned3()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReport(new DateTime(2018, 1, 1, 0, 0, 0), new DateTime(2018, 1, 16, 23, 59, 59));
            Assert.AreEqual(0, dic.Count);
        }

        [TestMethod]
        public void GetTotalOfUnpaid_NoInvoices_ZeroShouldBeReturned()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices1);
            var dic = invRepo.GetItemsReport(new DateTime(2018, 1, 1, 0, 0, 0), new DateTime(2018, 1, 16, 23, 59, 59));
            Assert.AreEqual(0, dic.Count);
        }
        
        [TestMethod]
        public void GetItemsReport_InvoicesExist_CorrectReportShouldBeReturned()
        {
            Dictionary<string, long> dic = new Dictionary<string, long>();
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var result = invRepo.GetItemsReport(null, null);

            Assert.AreEqual(dic.Count, result.Count);
        }

        [TestMethod]
        public void GetTotal_NoInvoices_NullShouldBeReturned2()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(12963);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTotal_NoInvoices_NullShouldBeReturned4()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices1);
            decimal? result = invRepo.GetTotal(1);
            Assert.AreEqual(null, result);
        }

        [TestMethod]
        public void GetTotal_NoInvoices_NullShouldBeReturned3()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(1263);
            Assert.AreEqual(null, result);
        }
        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned4()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(2);
            Assert.AreEqual(220, result);
        }
        [TestMethod]
        public void GetItemsReport_InvoicesExist_CorrectReportShouldBeReturned1()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReport(new DateTime(0001, 1, 1, 0, 0, 0), new DateTime(9999, 12, 31, 23, 59,59));
            Assert.AreEqual(10, dic.Count);
        }
        [TestMethod]
        public void GetTotal_InvoicesExist_CorrectValueShouldBeReturned()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            decimal? result = invRepo.GetTotal(6);
            Assert.AreEqual(3080, result);
        }
        [TestMethod]
        public void GetItemsReport_InvoicesExist_CorrectReportShouldBeReturned2()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReport(new DateTime(2018, 5, 16, 0, 0, 0), new DateTime(2018, 5, 16, 0, 0, 0));
            Assert.AreEqual(2, dic.Count);
        }

        [TestMethod]
        public void GetItemsReport_InvoicesExist_CorrectReportShouldBeReturned4()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReport(null, new DateTime(2018, 5, 16, 0, 0, 0));
            Assert.AreEqual(0, dic.Count);
        }

        [TestMethod]
        public void GetItemsReportNew_InvoicesExist_CorrectReportShouldBeReturned1()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReportNew(null, null);
            Assert.AreEqual(0, dic.Count);
        }

        [TestMethod]
        public void GetItemsReportNew_InvoicesExist_CorrectReportShouldBeReturned2()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReportNew(new DateTime(2018, 5, 1, 0, 0, 0), new DateTime(2018, 5, 16, 0, 0, 0));
            Assert.AreEqual(10, dic.Count);
        }

        [TestMethod]
        public void GetItemsReportNew_InvoicesExist_CorrectReportShouldBeReturned3()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReportNew(new DateTime(2018, 5, 1, 0, 0, 0), null);
            Assert.AreEqual(10, dic.Count);
        }

        [TestMethod]
        public void GetItemsReportNew_InvoicesExist_CorrectReportShouldBeReturned4()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var dic = invRepo.GetItemsReportNew(null, new DateTime(2018, 5, 16, 0, 0, 0));
            Assert.AreEqual(10, dic.Count);
        }




        [TestMethod]
        public void GetTotalOfUnpaid_InvoicesExist_CorrectValueShouldBeReturned()
        {
            InvoiceRepository invRepo = new InvoiceRepository(this._invoices);
            var total = invRepo.GetTotalOfUnpaid();
            Assert.AreEqual(24043, total);
        }
    }
}
