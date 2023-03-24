using System;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.Enuns;

namespace YouLearn.Doumain.Entities
{
    public  class Video : EntityBase
    {
        public Canal Canal { get; set; }
        public PlayList PlayList { get; set; }
        public string  Titulo { get; set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public string OrdemNaPlayList { get; set; }
        public string IdVideoYouTube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public EnumStatus Status { get; set; }

    }
}
