using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class HtmlElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private string tagBody;

        public HtmlElement(string tagName)
        {
            this.tagName = tagName;
            this.startTag = "";
            this.endTag = "";
            this.tagBody = "";
        }
        public override void GenerateHtml()
        {
            Console.WriteLine(startTag + "" + tagBody+""+endTag);
        }

        public override string GetTagName()
        {
            return this.tagName;
        }

        public override void SetEndTag(string endTag)
        {
            this.endTag = endTag;
        }

        public override void SetStartTag(string startTag)
        {
            this.startTag = startTag;
        }

        public override void SetTagBody(string tagBody)
        {
            this.tagBody = tagBody;
        }
    }
}
