using System;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.Enuns;

namespace YouLearn.Doumain.Entities
{
    public  class Video : EntityBase
    {
        public Video(Canal canal, PlayList playList, string titulo, string descricao, string tags, string ordemNaPlayList, string idVideoYouTube, Usuario usuarioSugeriu, EnumStatus status)
        {
            Canal = canal;
            PlayList = playList;
            Titulo = titulo;
            Descricao = descricao;
            Tags = tags;
            OrdemNaPlayList = ordemNaPlayList;
            IdVideoYouTube = idVideoYouTube;
            UsuarioSugeriu = usuarioSugeriu;
            Status = status;
        }

        public Canal Canal { get; private set; }
        public PlayList PlayList { get; private set; }
        public string  Titulo { get; private set; }
        public string Descricao { get; set; }
        public string Tags { get; set; }
        public string OrdemNaPlayList { get; set; }
        public string IdVideoYouTube { get; set; }
        public Usuario UsuarioSugeriu { get; set; }
        public EnumStatus Status { get; set; }

    }
}
