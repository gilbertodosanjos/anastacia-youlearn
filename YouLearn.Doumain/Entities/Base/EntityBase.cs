using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prmToolkit.NotificationPattern;

namespace YouLearn.Doumain.Entities.Base
{
    public abstract class EntityBase : Notifiable
    {
        public EntityBase() 
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid  Id { get; set; }

    }
}
