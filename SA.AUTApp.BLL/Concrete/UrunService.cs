using SA.AUTApp.DAL.Concrete;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.BLL.Concrete
{
    public class UrunService:BaseService<Urun>
    {
        private UrunRepo _repo;

        public UrunService(BaseRepo<Urun> baseRepo) : base(baseRepo)
        {
            _repo = (UrunRepo?)baseRepo;
        }
    }
}
