
AdicionarUsuarioRequest request  =  new AdicionarUsuarioRequest()
{

    Email =  "gilbertodosanjos@gmail.com",
    PrimeiroNome = "gilberto luiz" ,
   UltimoNome = "dos anjos ferreira",
   Senha = "1234"
};

var responde  = new ServiceUsuario().AdicionarUsuario(request);

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
