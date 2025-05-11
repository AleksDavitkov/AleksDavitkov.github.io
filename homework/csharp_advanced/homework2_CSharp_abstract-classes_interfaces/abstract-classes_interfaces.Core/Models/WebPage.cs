using abstract_classes_interfaces.Core.Interfaces;

namespace abstract_classes_interfaces.Core.Models
{
    public class WebPage : ISearchable
    {
        public string Url { get; set; }
        public string HtmlContent { get; set; }

        public WebPage(string url, string htmlContent)
        {
            Url = url;
            HtmlContent = htmlContent;
        }

        public bool Search(string word)
        {
            return HtmlContent.ToLower().Contains(word.ToLower());
        }
    }
}