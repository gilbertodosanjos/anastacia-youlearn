using System;
using prmToolkit.NotificationPattern;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.Enuns;

namespace YouLearn.Doumain.Entities
{
    
    public  class PlayList : EntityBase
    {
    
        public PlayList(string nome, Usuario usuario)
        {
            Nome = nome;
            Usuario = usuario;

            new AddNotifications<PlayList>(this).IfNullOrInvalidLength(x => x.Nome, 2, 100);

            AddNotifications(usuario);
        }

        public string  Nome { get; private set; }
        public Usuario Usuario { get; private set; }
        public EnumStatus Status { get; private set; }
    }
}
