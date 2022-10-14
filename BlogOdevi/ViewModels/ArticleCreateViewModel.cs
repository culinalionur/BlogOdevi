using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace BlogOdevi.ViewModels
{
    public class ArticleCreateViewModel
    {

        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Boş bırakılamaz")]
        public string Content { get; set; }

        [Display(Name = "Article Picture ")]
        public IFormFile ArticlePicture { get; set; }
    }
}

