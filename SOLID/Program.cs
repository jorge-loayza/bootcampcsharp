using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Invoice invoice = new Invoice(book);

            InvoicePersistence invoicePersistence = new(invoice);

            invoicePersistence.saveToFile("path");
        }
    }
    class Invoice
    {
        Book book;
        int quantity;
        double discountRate;
        double taxRate;
        double total;
        public Invoice(Book book)
        {
            this.book = book;
        }

        public double calculateTotal()
        {
            return 0;
        }
        
        
    }
    class Book
    {
        string name;
        string authourName;
        int year;
        int price;
        string isbn;
    }
}
