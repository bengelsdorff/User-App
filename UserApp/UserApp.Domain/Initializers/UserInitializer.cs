using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserApp.Domain;

namespace UserApp.Repository.Initializers
{
    public class UserInitializer : DropCreateDatabaseAlways<Context>
    {
        protected override void Seed(Context context)
        {
            context.Users.Add(new User() { Name = "Antonio", Email = "antonio.bengelsdorff@gmail.com", Password = "password" });

            base.Seed(context); 
        }
    }
}
