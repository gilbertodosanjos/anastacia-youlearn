
using YouLearn.Doumain.Entities;

namespace YouLearn.Doumain.Interfaces.Repositories
{
    public  interface IRepositoryUsuario
    {
        public Usuario Obter(Guid id);
        public Usuario Obter(string email, string senha);

        public void Salvar(Usuario usuario);

        public bool Existe(string emai);
    }
}
