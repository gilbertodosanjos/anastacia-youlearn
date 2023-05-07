using YouLearn.Domain.Entities;

namespace YouLearn.Domain.Arguments.Playlist;

public class PlayListResponse
{
    public Guid Id { get; set; }
    public string  Nome { get; set; }

    public static explicit operator PlayListResponse(PlayList entidade)
    {
        return new PlayListResponse()
        {
            Id = entidade.Id,
            Nome = entidade.Nome
        };
    }
}
