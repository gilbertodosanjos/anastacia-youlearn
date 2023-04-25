namespace YouLearn.Doumain.Arguments.Usuario
{
    public class AutenticarUsuarioRequest
    {
        public AutenticarUsuarioRequest(string email, string senha)
        {
            Email = email;
            Senha = senha;
        }

        public string  Email { get; private set; }
        public string Senha { get; private set; }
    }
}
