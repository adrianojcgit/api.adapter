using API.Adapter.Application.DTO;

namespace API.Adapter.Application.Interfaces
{
    public interface IPropostaServices
    {
        Task<bool> AdicionarProposta(PropostaBaseDto propostaDto);
    }
}
