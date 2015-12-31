using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Data.Entity;
using MvcAngular.Domain.Entities;
using MvcAngular.Domain.Abstract;

namespace MvcAngular.Domain.Concrete
{
 
  public class MyDatabaseEntities  : DbContext
  {
    public MyDatabaseEntities() : base("name=MyDatabaseEntities ")
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