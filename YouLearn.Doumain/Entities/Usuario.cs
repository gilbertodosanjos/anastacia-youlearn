using System;
using YouLearn.Doumain.Entities.Base;
using YouLearn.Doumain.ValueObjects;

namespace YouLearn.Doumain.Entities
{
    public class Usuario : EntityBase
    {
        public Nome  Nome { get; set; }
        public Email  Email { get; set; }
        public string  Senha { get; set; }
    }
}
