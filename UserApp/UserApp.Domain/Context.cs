using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Repository.Initializers;

namespace UserApp.Domain
{
    public class Context : DbContext
    {

        public Context() : base()
        {
            Database.SetInitializer(new UserInitializer());
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
