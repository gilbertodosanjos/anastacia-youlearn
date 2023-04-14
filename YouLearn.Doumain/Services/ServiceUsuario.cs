using prmToolkit.NotificationPattern;
using System;
using YouLearn.Doumain.Arguments.Usuario;
using YouLearn.Doumain.Entities;
using YouLearn.Doumain.Interfaces.Repositories;
using YouLearn.Doumain.Interfaces.Services;
using YouLearn.Doumain.ValueObjects;

namespace YouLearn.Doumain.Services
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
