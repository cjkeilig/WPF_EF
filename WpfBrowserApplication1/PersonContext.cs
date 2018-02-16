using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using WpfBrowserApplication1.ViewModel;

namespace WpfBrowserApplication1
{
    class PersonContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
    }
}
