using BlogOdevi.Context;
using BlogOdevi.GenericRepositoryPattern.BaseRepository;
using BlogOdevi.Models.Concrete;

namespace BlogOdevi.GenericRepositoryPattern.ConcRepository
{
    public class ArticleRepository : BaseRepository<Article>
    {
        public ArticleRepository(AppDbContext context) : base (context)
        {

        }
    }
}
