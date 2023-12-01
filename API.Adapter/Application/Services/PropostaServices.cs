using API.Adapter.Application.DTO;
using API.Adapter.Application.Interfaces;
using API.Adapter.Domain.Entities;
using API.Adapter.Domain.Interfaces;
using AutoMapper;

namespace API.Adapter.Application.Services
{
    public class PropostaServices: IPropostaServices
    {
        private readonly IPropostaRepository _propostaRepository;
        private readonly IMapper _mapper;
        public PropostaServices(IPropostaRepository propostaRepository, IMapper mapper)
        {
            _propostaRepository = propostaRepository;
            _mapper = mapper;
        }

        public async Task<bool> AdicionarProposta(PropostaBaseDto propostaDto)
        {
            var proposta = _mapper.Map<PropostaBase>(propostaDto);
            return await _propostaRepository.AdicionarProposta(proposta);
        }
    }
}
