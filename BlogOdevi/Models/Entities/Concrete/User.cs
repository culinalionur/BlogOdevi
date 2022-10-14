using BlogOdevi.Models.Abstract;
using System.Collections.Generic;

namespace BlogOdevi.Models.Concrete
{
    public class User : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public List<Article> Articles { get; set; }
    }
}
