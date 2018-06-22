using HtmlAgilityPack;

namespace ConsoleDemo
{
    public static class HTMLHelper
    {
        public static HtmlDocument GetDocument(string HtmlString)
        {
            var document = new HtmlDocument();

            document.LoadHtml(HtmlString);

            return document;
        }

        public static HtmlNode GetFirstNode(HtmlDocument document)
        {
            var node = document.DocumentNode.FirstChild;

            return node;
        }
    }
}
