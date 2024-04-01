using Microsoft.EntityFrameworkCore;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.DAL.Context
{
    public class SA_AUTAppDbContext:DbContext
    {

       public  DbSet<Kullanici> Kullanicis { get; set; }
       public DbSet<Urun>Uruns { get; set; }
       public DbSet<KullaniciUrun> KullaniciUruns { get; set; }
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=SERGEN\SQLEXPRESS;Initial Catalog=AUTApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
