using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class InvoicePersistence
    {
        private Invoice invoice;
        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }
        public void saveToFile(String file)
        {
            Console.WriteLine("Save Invoice to {0} ({1})", file, invoice);
        }
    }
}
