using System;
using YouLearn.Doumain.Entities;

namespace YouLearn.Doumain.Interfaces.Repositories
{
    public  interface IRepositiryUsuario
    {
        Usuario Obter(Guid Id);
        Usuario Obter(string email, string senha);

        void Salvar(Usuario usuario);

        bool Existe(string emai);
    }
}
