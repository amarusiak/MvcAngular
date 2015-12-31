using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;

namespace MvcAngular.Domain
{
 
  public class MyDatabaseEntities : DbContext
  {
    public MyDatabaseEntities()
      : base("name=MyDatabaseEntities")
    {
    }

    //protected override void OnModelCreating(DbModelBuilder modelBuilder)
    //{
    //  throw new UnintentionalCodeFirstException();
    //}

    //public DbSet<Contact> Contacts { get; set; }
    public DbSet<User> Users { get; set; }
  }
}