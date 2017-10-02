using Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MyContext : IdentityDbContext<Kullanici>
    {
        public MyContext() : base("MyConnection") { }
        public virtual DbSet<Kategori> Kategoriler {get;set;}
        public virtual DbSet<Blog> Bloglar { get; set; }
      
    }
}
