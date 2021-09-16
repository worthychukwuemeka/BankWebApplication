using BankApplication.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BankApplication.Data
{
    public class BankDbContext : IdentityDbContext<BankApplicationUser>
    {
        public BankDbContext(DbContextOptions<BankDbContext> options)
            : base(options)
        {
        }
    }
}
