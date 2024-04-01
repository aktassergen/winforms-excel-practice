using SA.AUTApp.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA.AUTApp.Entity.Concrete
{
    public class BaseEntity : IEntity
    {
        public int Id { get; set; }
    }
}
