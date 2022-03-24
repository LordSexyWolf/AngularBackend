using AngularBackend.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularBackend
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> op): base(op) { }
        public DbSet<CreditCard> DBCreditCard { get; set; }
    }
}
