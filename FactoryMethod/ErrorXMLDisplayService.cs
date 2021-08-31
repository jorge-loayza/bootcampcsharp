using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class ErrorXMLDisplayService : DisplayService, XMLParser
    {
       
        public ErrorXMLDisplayService()
        {
           this.XMLParser = XMLParserCreator.Create(XMLParserCreator.ERROR_XMLPARSER);
        }
        
    }
}
