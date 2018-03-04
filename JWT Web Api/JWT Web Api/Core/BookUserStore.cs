using Microsoft.AspNet.Identity.EntityFramework;
namespace JWT_Web_Api.Core
{
    public class BookUserStore : UserStore<IdentityUser>
    {
        public BookUserStore() : base(new BooksContext())
        {
        }
    }
}