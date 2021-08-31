using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            ErrorXMLDisplayService errorXMLDisplayService = new ErrorXMLDisplayService();
            Console.WriteLine(errorXMLDisplayService.parse());
            errorXMLDisplayService.Display();
            XMLParser errorXMLParser = errorXMLDisplayService.GetParser();
        }
    }
}
