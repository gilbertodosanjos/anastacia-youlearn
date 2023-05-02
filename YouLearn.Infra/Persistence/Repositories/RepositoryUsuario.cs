
using System;
using YouLearn.Doumain.Entities;
using YouLearn.Doumain.Interfaces.Repositories;


namespace YouLearn.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        bool IRepositoryUsuario.Existe(string emai)
        {
            throw new NotImplementedException();
        }

        Usuario IRepositoryUsuario.Obter(Guid Id)
        {
            throw new NotImplementedException();
        }

        Usuario IRepositoryUsuario.Obter(string email, string senha)
        {
            throw new NotImplementedException();
        }

        void IRepositoryUsuario.Salvar(Usuario usuario)
        {
            throw new NotImplementedException();
        }
    }
}


