using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.Entity.Concrete
{
    public class KullaniciUrun:BaseEntity
    {
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int UrunId { get; set; }
        public Urun Urun { get; set; }
    }
}
