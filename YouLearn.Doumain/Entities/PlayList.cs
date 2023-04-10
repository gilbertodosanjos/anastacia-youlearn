using System;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.Enuns;

namespace YouLearn.Doumain.Entities
{
    public  class PlayList : EntityBase
    {
        public PlayList(Usuario usuario, EnumStatus status)
        {
            Usuario = usuario;
            Status = status;
        }

        public Usuario Usuario { get; set; }
        public EnumStatus Status { get; set; }
    }
}
