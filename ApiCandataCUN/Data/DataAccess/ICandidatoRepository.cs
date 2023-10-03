using ApiCandataCUN.Models;

namespace ApiCandataCUN.Data.DataAccess
{
    public interface ICandidatoRepository
    {
        Candidato GetCandidatoById(string id);
        IEnumerable<Candidato> GetAllCandidatos();
        void CreateCandidato(Candidato candidato);
    }
}
