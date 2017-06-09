using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TataApp.Domain
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }

        public System.Data.Entity.DbSet<TataApp.Domain.LoginType> LoginTypes { get; set; }
        public System.Data.Entity.DbSet<TataApp.Domain.Employee> Employees { get; set; }
        public System.Data.Entity.DbSet<TataApp.Domain.DocumentType> DocumentTypes { get; set; }
    }
}
