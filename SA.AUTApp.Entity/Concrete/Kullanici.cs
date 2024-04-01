using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.Entity.Concrete
{
    public class Kullanici:BaseEntity
    {
        public string KullaniciAdi { get; set; }
        public string KullaniciSifre { get; set; }
        public List<KullaniciUrun> kullaniciUruns { get; set; }
    }
}
