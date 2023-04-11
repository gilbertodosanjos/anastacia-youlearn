using System;
using YouLearn.Doumain.Entities.Base;

namespace YouLearn.Doumain.Entities
{
    public  class Canal : EntityBase
    {
        public Canal(string nome, string urlLogo, Usuario usuario)
        {
            Nome = nome;
            UrlLogo = urlLogo;
            Usuario = usuario;
        }

        public string Nome { get; private set; }
        public string UrlLogo { get; private set; }
        public Usuario Usuario { get; private set; }

    }
}
