using Microsoft.EntityFrameworkCore;
using NewCRM.Databases.Entities;

namespace NewCRM.Databases
{
    public class Context : DbContext
    {
        private static Context _Instance;
        public static Context Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new Context();
                }
                return _Instance;
            }
            private set { }
        }

        private Context()
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactAddress> ContactAddresses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=192.168.2.231;database=CRM_MinhTri;user id=sa;password=vStation123;");
        }
    }
}
