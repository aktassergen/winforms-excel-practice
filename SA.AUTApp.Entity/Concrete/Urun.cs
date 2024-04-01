using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.Entity.Concrete
{
    public class Urun:BaseEntity
    {
        public int Ay { get; set; }
        public string UrunName { get; set; }
        public int Tonaj { get; set; }
        public List<KullaniciUrun> kullaniciUruns { get; set; }
    }
}
