using API.Adapter.Domain.Entities;

namespace API.Adapter.Domain.Interfaces
{
    public interface IPropostaRepository
    {
        Task<bool> AdicionarProposta(PropostaBase proposta);
    }
}
