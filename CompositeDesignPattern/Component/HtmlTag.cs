using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern
{
    abstract class HtmlTag
    {
        public abstract string GetTagName();
        public abstract void SetStartTag(string startTag);
        public abstract void SetEndTag(string endTag);

        public virtual void SetTagBody(string tagBody)
        {
            throw new NotImplementedException();
        }
        public virtual void AddChildTag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveChildTag(HtmlTag htmlTag)
        {
            throw new NotImplementedException();
        }

        public virtual List<HtmlTag> GetChildren()
        {
            throw new NotImplementedException();
        }
        public abstract void  GenerateHtml();
    }
}
