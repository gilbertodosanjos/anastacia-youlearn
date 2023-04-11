using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouLearn.Doumain.Arguments.Usuario
{
    public  class AutenticarUsuarioResponse
    {
        public AutenticarUsuarioResponse(Guid id, string primeiroNome)
        {
            Id = id;
            PrimeiroNome = primeiroNome;
        }

        public Guid Id { get; private set; }
        public string  PrimeiroNome { get; private set; }
    }
}
