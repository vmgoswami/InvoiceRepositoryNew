using System;
using System.Collections.Generic;
using System.Linq;

namespace InvoiceRepositories
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Invoice> inviceList = new List<Invoice>()
{
new Invoice(){ Id = 1, Description="First Order" , Number = "134/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 1, 0, 0, 0) ,AcceptanceDate =DateTime.Now,
 InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test1", Count=5, Price = 10 },
    new InvoiceItem(){ Name = "Test11",  Count=5, Price = 100 }}
 },
new Invoice(){ Id = 2, Description="First Order" , Number = "135/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 6,  0, 0, 0),AcceptanceDate =DateTime.Now,
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test2",  Count=5, Price = 20 },
  new InvoiceItem(){ Name = "Test22", Count=5, Price = 200 }}
 },
new Invoice(){ Id = 3, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 7,  0, 0, 0),AcceptanceDate =DateTime.Now,
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
},

  new Invoice(){ Id = 4, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 8,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }},
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 }
 ,
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 9,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 13,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 14,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test3", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 14,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test7", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 14,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test6", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 15,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test5", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 15,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test4", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 16,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test4", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 },
  new Invoice(){ Id = 5, Description="First Order" , Number = "136/10/2018", Seller ="VMG", Buyer="OM", CreationDate = new DateTime(2008, 5, 15,  0, 0, 0),
  InvoiceItems = new List<InvoiceItem>(){ new InvoiceItem(){ Name = "Test4", Count=5, Price = 30 },
  new InvoiceItem(){ Name = "Test33", Count=5, Price = 300 }}
 }
};
            InvoiceRepository invRepo = new InvoiceRepository(inviceList.AsQueryable());
            //decimal? result = invRepo.GetTotal(1234567896);


            //var total = invRepo.GetItemsReport(new DateTime(2008, 5, 1, 0, 0, 0), new DateTime(2008, 5, 16, 0, 0, 0));
            var total = invRepo.GetItemsReport(new DateTime(2008, 5, 1, 0, 0, 0), new DateTime(2008, 5, 16, 0, 0, 0));
            Console.WriteLine(total.ToString());
        }
    }
}
