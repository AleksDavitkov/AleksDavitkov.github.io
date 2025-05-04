using abstract_classes_interfaces.Core.Interfaces;

namespace abstract_classes_interfaces.Core.Models
{
    public class Document : ISearchable
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public Document(string title, string content)
        {
            Title = title;
            Content = content;
        }

        public bool Search(string word)
        {
            return Content.ToLower().Contains(word.ToLower());
        }
    }
}