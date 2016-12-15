using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoderF.DAL
{
    public class CFContext : DbContext
    {
        public CFContext()
            : base("CFContext")
        {

        }

        public DbSet<CFUser> CFUsers { get; set; }
    }
}
