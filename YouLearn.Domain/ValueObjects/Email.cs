using prmToolkit.NotificationPattern;
using prmToolkit.NotificationPattern.Extensions;
using YouLearn.Domain.Resources;

namespace YouLearn.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        protected Email()
        {

        }
        
        public Email(string endereco)
        {
            Endereco = endereco;

            new AddNotifications<Email>(this)
                .IfNotEmail(x=>x.Endereco,MSG.X0_INVALIDO.ToFormat("E-Mail"));

        }

        public string  Endereco { get; private set; }
    }
}
