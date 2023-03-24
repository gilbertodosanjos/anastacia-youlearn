using System;
using YouLearn.Doumain.Entities.Base;

namespace YouLearn.Doumain.Entities
{
    public  class Canal : EntityBase
    {
    
        public string Nome { get; set; }
        public string UrlLogo { get; set; }
        public Usuario Usuario { get; set; }

    }
}
