using SA.AUTApp.DAL.Context;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.DAL.Concrete
{
    public class UrunRepo:BaseRepo<Urun>
    {
        public UrunRepo(SA_AUTAppDbContext sa):base(sa) 
        {
            
        }
    }
}
