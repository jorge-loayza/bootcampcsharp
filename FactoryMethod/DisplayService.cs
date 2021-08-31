using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DisplayService: XMLParser
    {
        public XMLParser XMLParser;


        public void Display()
        {
            Console.WriteLine("Display Method");
        }

        public XMLParser GetParser()
        {
            return this.XMLParser;
        }

        public string parse()
        {
            return "Parse";
        }
    }
}
