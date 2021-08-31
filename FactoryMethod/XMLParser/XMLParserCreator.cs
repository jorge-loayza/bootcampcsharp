using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class XMLParserCreator
    {
        public const int ERROR_XMLPARSER = 1;
        public const int ORDER_XMLPARSER = 2;
        public const int RESPONSE_XMLPARSER = 3;
        public const int FEEDBACK_XMLPARSER = 4;

        public static XMLParser Create(int xmlparser)
        {
            switch (xmlparser)
            {
                case ERROR_XMLPARSER:
                    return new ErrorXMLParser();
                case ORDER_XMLPARSER:
                    return new ErrorXMLParser();
                case RESPONSE_XMLPARSER:
                    return new ErrorXMLParser();
                case FEEDBACK_XMLPARSER:
                    return new ErrorXMLParser();
                default:
                    return null;
            }
        }
    }
}
