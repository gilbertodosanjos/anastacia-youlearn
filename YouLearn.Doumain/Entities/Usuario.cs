using System;
using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using YouLearn.Domain.Resources;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.Extensions;
using YouLearn.Doumain.ValueObjects;

namespace YouLearn.Doumain.Entities
{
    public class Usuario : EntityBase
    {
        public Usuario(Email email, string senha)
        {
            Email = email;
            Senha = senha;

            //Criptografo a senha
            Senha = Senha.ConvertToMD5();

            AddNotifications(email);
        }

        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            new AddNotifications<Usuario>(this).IfNullOrInvalidLength(x => x.Senha, 3, 32);

            //Criptografo a senha
            Senha = Senha.ConvertToMD5();

            AddNotifications(nome, email);
        }

        public Nome  Nome { get; private set; }
        public Email  Email { get; private set; }
        public string  Senha { get; private set; }
    }
}
