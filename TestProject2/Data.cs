using System;
using System.Collections.Generic;
using System.Text;
using InvoiceRepositories;

namespace InvoiceTest
{
    public static class Data
    {
        public static IList<Invoice> GetData()
        {

            IList<Invoice> invoiceList = new List<Invoice>() {
         new Invoice() {
             Id = 1, Description = "Order 1", Number = "134/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 1, 0, 0, 0), AcceptanceDate = DateTime.Now,
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test1", Count = 5, Price = 10
                   },
                   new InvoiceItem() {
                     Name = "Test11", Count = 5, Price = 100
                   }
               }
           },
           new Invoice() {
             Id = 2, Description = "Order 2", Number = "135/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 6, 0, 0, 0), AcceptanceDate = DateTime.Now,
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test2", Count = 5, Price = 20
                   },
                   new InvoiceItem() {
                     Name = "Test22", Count = 5, Price = 200
                   }
               }
           },
           new Invoice() {
             Id = 3, Description = "Order 3", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 7, 0, 0, 0), AcceptanceDate = DateTime.Now,
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test3", Count = 5, Price = 30
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 300
                   }
               }
           },
           new Invoice() {
             Id = 4, Description = "Order 4", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 8, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test3", Count = 5, Price = 40
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 2300
                   }
               }
           },
           new Invoice() {
             Id = 5, Description = "Order 5", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 9, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test3", Count = 5, Price = 50
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3002
                   }
               }
           },
           new Invoice() {
             Id = 6, Description = "Order 6", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 13, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test3", Count = 5, Price = 60
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3020
                   }
               }
           },
           new Invoice() {
             Id = 7, Description = "Order 7", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 14, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test3", Count = 5, Price = 70
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3200
                   }
               }
           },
           new Invoice() {
             Id = 8, Description = "Order 8", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 14, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test7", Count = 5, Price = 80
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3001
                   }
               }
           },
           new Invoice() {
             Id = 9, Description = "Order 9", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 14, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test6", Count = 5, Price = 90
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3010
                   }
               }
           },
           new Invoice() {
             Id = 10, Description = "Order 10", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 15, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test5", Count = 5, Price = 100
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 3100
                   }
               }
           },
           new Invoice() {
             Id = 11, Description = "Order 11", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 15, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test4", Count = 5, Price = 110
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 1300
                   }
               }
           },
           new Invoice() {
             Id = 12, Description = "Order 12", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 16, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test4", Count = 5, Price = 120
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 100
                   }
               }
           },
           new Invoice() {
             Id = 13, Description = "Order 13", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 15, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test4", Count = 5, Price = 130
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 200
                   }
               }
           },

           new Invoice() {
             Id = 14, Description = "Order 14", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 15, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test4", Count = 5, Price = 130
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 300
                   }
               }
           },
           new Invoice() {
             Id = 15, Description = "Order 15", Number = "136/10/2018", Seller = "VMG", Buyer = "OM", CreationDate = new DateTime(2018, 5, 15, 0, 0, 0),
               InvoiceItems = new List < InvoiceItem > () {
                 new InvoiceItem() {
                     Name = "Test4", Count = 5, Price = 130
                   },
                   new InvoiceItem() {
                     Name = "Test33", Count = 5, Price = 400
                   }
               }
           }
       };
            return invoiceList;
        }

        public static IList<Invoice> GetData1()
        {
            IList<Invoice> invoiceList = new List<Invoice>() {
         new Invoice() {
           Id = -1,
             Description = "Order",
             Number = "134/10/2018",
             Seller = "VMG",
             Buyer = "OM",
             CreationDate = new DateTime(2018, 5, 1, 0, 0, 0),
             AcceptanceDate = DateTime.Now,
             InvoiceItems = new List < InvoiceItem > () {
               new InvoiceItem() {
                   Name = "Test1", Count = 5, Price = 10
                 },
                 new InvoiceItem() {
                   Name = "Test11", Count = 5, Price = 100
                 }
             }
         }
       };
            return invoiceList;
        }
    }
}
