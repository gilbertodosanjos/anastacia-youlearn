using YouLearn.Doumain.Arguments.Usuario;

namespace YouLearn.Doumain.Interfaces.Services
{
    public interface IServiceUsuario
    {
        AdicionarUsuarioResponse AdicionarUsuario(AdicionarUsuarioRequest request);
        AutenticarUsuarioResponse AutenticarUsuario(AutenticarUsuarioRequest request);

    }
}
