using System;
using System.Data.Entity;

namespace UserApp.Domain.Interfaces
{
    public interface IContext
    {

        DbSet<User> Users { get; set; }
    }
}
