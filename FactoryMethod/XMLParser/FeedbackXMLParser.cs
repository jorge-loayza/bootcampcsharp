using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class FeedbackXMLParser: XMLParser
    {
        public string parse()
        {
            return "FeedbackXMLParser";
        }
    }
}
