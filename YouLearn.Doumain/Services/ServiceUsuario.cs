using prmToolkit.NotificationPattern;
using System;
using YouLearn.Doumain.Arguments.Usuario;
using YouLearn.Doumain.Entities;
using YouLearn.Doumain.Interfaces.Services;

namespace YouLearn.Doumain.Services
{
    public class ServiceUsuario : Notifiable, IServiceUsuario
    {
        public AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request)
        {
            if (request == null) 
            {
                AddNotification("AdicionarUsuarioRequest","Objeto AdicionarUsuario é obrigatório");
                return null;
            }

            Usuario usuario = new Usuario();
            usuario.Nome.PrimeiroNome = "Gilberto Luiz";
            usuario.Nome.UltimoNome = "dos Anjos";
            usuario.Email.Emdereco = "gilbertodosanjos@gmail.com";
            usuario.Senha = "123456";

            if (usuario.Nome.PrimeiroNome.Length < 3 || usuario.Nome.PrimeiroNome.Length > 50) 
            {
                throw new Exception("Utimo nome é obrigatório e deve ter entre 3 e 50 caracteres");
            }

            if (usuario.Email.Emdereco.IndexOf("@") < 1) 
            {
                throw new Exception("Email invalido");
            }

            if (usuario.Senha.Length >=3) 
            {
                throw new Exception("Senha deve ter no minimo 3 carasteres");
            }

            // persiste no banco de dados
             AdicionarUsuarioResponse response = new RepositoryUsuario().Salvar(usuario);

            return response;


        }

        public AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request)
        {
            throw new System.NotImplementedException();
        }
    }
}
