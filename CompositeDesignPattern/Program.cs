using System;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            HtmlTag parentTag = new HtmlParentElement("<html>");
            parentTag.SetStartTag("<html>");
            parentTag.SetEndTag("</html>");

            HtmlTag p1 = new HtmlParentElement("<body>");
            p1.SetStartTag("<body>");
            p1.SetEndTag("</body>");

            parentTag.AddChildTag(p1);

            HtmlTag child1 = new HtmlElement("<p>");
            child1.SetStartTag("<p>");
            child1.SetEndTag("</p>");
            child1.SetTagBody("Testing html tag library");
            p1.AddChildTag(child1);

            child1 = new HtmlElement("<p>");
            child1.SetStartTag("<p>");
            child1.SetEndTag("</p>");
            child1.SetTagBody("Paragraph 2");
            p1.AddChildTag(child1);

            parentTag.GenerateHtml();
        }
    }
}
