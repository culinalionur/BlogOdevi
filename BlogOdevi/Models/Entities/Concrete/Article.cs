using BlogOdevi.Models.Abstract;
using System;

namespace BlogOdevi.Models.Concrete
{
    public class Article : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string ArticlePicture { get; set; }
        public DateTime CreatedTime { get; set; } = DateTime.Now;
        public string GetContentSummary()
        {
            int limit = 250;
            string summary = string.Empty;
            if (Content.Length >= limit)
            {

                summary = string.Format("{0}...", Content.Substring(0, limit));
            }
            else
            {
                summary = Content;
            }
            return summary;
       
    }
        public int AuthorId { get; set; }
        public User Author { get; set; }
    }
}
