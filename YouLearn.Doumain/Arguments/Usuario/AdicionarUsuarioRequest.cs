namespace YouLearn.Doumain.Arguments.Usuario
{
    public class AdicionarUsuarioRequest
    {
        public AdicionarUsuarioRequest(string primeiroNome, string ultimoNome, string email, string senha)
        {
            PrimeiroNome = primeiroNome;
            UltimoNome = ultimoNome;
            Email = email;
            Senha = senha;
        }

        public string  PrimeiroNome { get; set; }
        public string UltimoNome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
