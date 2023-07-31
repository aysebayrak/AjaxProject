using Microsoft.EntityFrameworkCore;

namespace Casgem_Ajax.DAL
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-D19MH5E\\SQLEXPRESS;initial catalog=CasgemDbAjax;integrated security=true");
        }

       public    DbSet<Customer>  Customers { get; set; }


    }
}
