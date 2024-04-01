using SA.AUTApp.DAL.Concrete;
using SA.AUTApp.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.BLL.Concrete
{
    public class KullaniciServise : BaseService<Kullanici>
    {
        private KullaniciRepo _repo;

        public KullaniciServise(KullaniciRepo kullaniciRepo) : base(kullaniciRepo)
        {
            _repo = kullaniciRepo;
        }

        public int Login(string username, string password)
        {
           var data= _repo.GetAll().FirstOrDefault(x=>x.KullaniciAdi==username && x.KullaniciSifre==password);
            if (data != null)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
