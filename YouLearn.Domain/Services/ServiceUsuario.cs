using prmToolkit.NotificationPattern;
using YouLearn.Domain.Arguments.Usuario;
using YouLearn.Domain.Entities;
using YouLearn.Domain.Interfaces.Repositories;
using YouLearn.Domain.Interfaces.Services;
using YouLearn.Domain.ValueObjects;

namespace YouLearn.Domain.Services
{
    
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        //Dependencias
         private readonly IRepositoryUsuario _repositoryUsuario;

        public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
        {
            _repositoryUsuario = repositoryUsuario;
        }

        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            Nome nome = new Nome(request.PrimeiroNome, request.UltimoNome);
            Email email = new Email(request.Email);
            Usuario usuario = new Usuario(nome, email, request.Senha);

            AddNotifications(usuario);

            _repositoryUsuario.Salvar(usuario);

            
            // persiste no banco de dados
            //AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);

            //return response;
            return new AdicionarUsuarioResponse(Guid.NewGuid());


        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
