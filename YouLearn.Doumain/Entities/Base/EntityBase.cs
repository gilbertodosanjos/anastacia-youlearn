using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouLearn.Doumain.Entities.Base
{
    public abstract class EntityBase
    {
        public EntityBase() 
        {
            Id = Guid.NewGuid();
        }

        public virtual Guid  Id { get; set; }

    }
}
