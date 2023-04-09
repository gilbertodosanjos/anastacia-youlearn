using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YouLearn.Doumain.Entities.Base;

namespace YouLearn.Doumain.Entities
{
    public class Favorito : EntityBase
    {
        public Video Video { get; set; }
        public Usuario Usuario { get; set; }
    }
}
