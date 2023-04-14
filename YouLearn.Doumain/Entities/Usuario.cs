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
        public Usuario(Nome nome, Email email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;

            AddNotifications(nome,email);

            new AddNotifications<Usuario>(this)
                .IfNullOrInvalidLength(x=>x.Senha,1,10,MSG.X0_OBRIGATORIA_E_DEVE_CONTER_ENTRE_X1_E_X2_CARACTERES.ToFormat("Senha",3,10));

            Senha = Senha.ConvertToMD5();      

        }

        public Nome  Nome { get; private set; }
        public Email  Email { get; private set; }
        public string  Senha { get; private set; }
    }
}
