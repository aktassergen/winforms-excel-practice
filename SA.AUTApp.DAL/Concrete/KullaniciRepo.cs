using SA.AUTApp.DAL.Context;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.DAL.Concrete
{
    public class KullaniciRepo:BaseRepo<Kullanici>
    {
        public KullaniciRepo(SA_AUTAppDbContext sa):base(sa) 
        {
            
        }
    }
}
