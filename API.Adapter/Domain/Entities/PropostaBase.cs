namespace API.Adapter.Domain.Entities
{
    public class PropostaBase
    {
        public List<Proposta> Propostas { get; set; }
        public PropostaBase(List<Proposta> propostas)
        {
            Propostas = propostas;
        }
    }
}
