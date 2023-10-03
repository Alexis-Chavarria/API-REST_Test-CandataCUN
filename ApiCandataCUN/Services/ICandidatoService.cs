using ApiCandataCUN.Models;

namespace ApiCandataCUN.Services
{
    public interface ICandidatoService
    {   
        void crearCandidato(Candidato candidato);
        Candidato obtenerCandidatoPorId(string id);
        IEnumerable<Candidato> obtenerCandidatos();
    }
}
