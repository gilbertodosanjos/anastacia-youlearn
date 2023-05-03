
using System;
using System.Linq;
using YouLearn.Doumain.Entities;
using YouLearn.Doumain.Interfaces.Repositories;
using YouLearn.Infra.Persistence.EF;

namespace YouLearn.Infra.Persistence.Repositories
{
    public class RepositoryUsuario : IRepositoryUsuario
    {
        private readonly YouLearnContext _context;

        public RepositoryUsuario(YouLearnContext context)
        {
            _context = context;
        }

        bool IRepositoryUsuario.Existe(string email)
        {
            return _context.Usuarios.Any(x=>x.Email.Endereco == email);
        }

        Usuario IRepositoryUsuario.Obter(Guid id)
        {
            return _context.Usuarios.FirstOrDefault(x=>x.Id == id);
        }

         Usuario IRepositoryUsuario.Obter(string email, string senha)
        {
            return _context.Usuarios.FirstOrDefault(x=>x.Email.Endereco  == email && x.Senha == senha );
        }

        void IRepositoryUsuario.Salvar(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
        }
    }
}


