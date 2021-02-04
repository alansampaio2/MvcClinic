using Microsoft.EntityFrameworkCore;
using MvcClinic.MVC.Models;

namespace MvcClinic.MVC.Data
{
    public class MvcClinicContext : DbContext
    {
        public MvcClinicContext(DbContextOptions<MvcClinicContext> options)
            : base(options)
        { }

        public DbSet<Client> Clients { get; set; }
    }
}
