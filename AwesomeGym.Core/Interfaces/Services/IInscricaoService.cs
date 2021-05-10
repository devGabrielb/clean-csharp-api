using AwesomeGym.Core.DTOs;
using AwesomeGym.Core.Entities;

namespace AwesomeGym.Core.Interfaces.Services
{
    public interface IInscricaoService
    {
        ResultadoInscricaoDTO Realizar(
            Aluno aluno,
            Unidade unidade,
            TurmaAtividade turmaAtividade);

    }
}