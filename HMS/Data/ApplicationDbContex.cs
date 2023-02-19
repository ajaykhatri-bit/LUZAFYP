using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HMS.Data
{
    public class ApplicationDbContex : IdentityDbContext
    {
        public ApplicationDbContex(DbContextOptions options) : base(options)
        {
        }
    }
}
