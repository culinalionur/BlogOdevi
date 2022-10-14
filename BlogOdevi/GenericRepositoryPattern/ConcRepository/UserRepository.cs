using BlogOdevi.Context;
using BlogOdevi.GenericRepositoryPattern.BaseRepository;
using BlogOdevi.Models.Concrete;

namespace BlogOdevi.GenericRepositoryPattern.ConcRepository
{
    public class UserRepository : BaseRepository<User> 
    {
        public UserRepository(AppDbContext context) : base(context)
        {

        }
    }
}
