using BlogOdevi.Filters;
using BlogOdevi.GenericRepositoryPattern.IntRepository;
using BlogOdevi.Managers;
using BlogOdevi.Models.Concrete;
using BlogOdevi.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;




namespace BlogOdevi.Controllers
{
    [LoggedUser]
    public class ArticleController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IGenericRepository<Article> _genericRepository;

        public ArticleController(IWebHostEnvironment webHostEnvironment, IGenericRepository<Article> genericRepository)
        {
            _webHostEnvironment = webHostEnvironment;
            _genericRepository = genericRepository;
        }
        public IActionResult Create(string yonlen)
        {
            ViewBag.yonlen = yonlen;
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ArticleCreateViewModel model, string yonlen)
        {
            if (ModelState.IsValid)
            {
                var article = new Article()
                {
                    Title = model.Title,
                    Content = model.Content,
                    ArticlePicture = model.ArticlePicture.GetUniqueNameAndSavePhotoToDisk(_webHostEnvironment)
                };
                _genericRepository.Add(article);
                TempData["message"] = "Article Created!";
                if (string.IsNullOrEmpty(yonlen))
                {
                    return RedirectToAction("List");
                }
                return Redirect(yonlen);
            }
            else
                return View();
        }
    }
}
