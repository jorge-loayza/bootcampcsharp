using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    class HtmlParentElement : HtmlTag
    {
        private string tagName;
        private string startTag;
        private string endTag;
        private List<HtmlTag> childrenTag;

        public HtmlParentElement(String tagName)
        {
            this.tagName = tagName;
            this.startTag = "";
            this.endTag = "";
            this.childrenTag = new List<HtmlTag>();
        }
        public override void GenerateHtml()
        {
            Console.WriteLine(startTag);
            foreach (var htmlTag in childrenTag)
            {
                htmlTag.GenerateHtml();
            }
            Console.WriteLine(endTag);
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

        public override void AddChildTag(HtmlTag htmlTag)
        {
            childrenTag.Add(htmlTag);
        }

        public override void RemoveChildTag(HtmlTag htmlTag)
        {
            childrenTag.Remove(htmlTag);
        }

        public override List<HtmlTag> GetChildren()
        {
            return childrenTag;
        }
    }
}
