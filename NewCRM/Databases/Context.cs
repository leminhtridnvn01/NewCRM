using Microsoft.EntityFrameworkCore;
using NewCRM.Databases.Entities;

namespace NewCRM.Databases
{
    public class Context : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.2.231;database=CRM_MinhTri;user id=sa;password=vStation123;");
        }
    }
}
