using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain.Interfaces;
using UserApp.Repository.Initializers;

namespace UserApp.Domain
{
    public class Context : DbContext, IContext
    {

        public Context() : base("Context")
        {
            this.Database.CommandTimeout = 180;
             Database.SetInitializer(new UserInitializer());
        }

        public virtual DbSet<User> Users { get; set; }

    }
}
