using System.Threading.Tasks;
using AwesomeGym.Core.DTOs;

namespace AwesomeGym.Core.Interfaces.Services
{
    public interface IErpIntegrationService
    {
        Task AdicionarPessoa(AdicionarPessoaErpDTO pessoa);
    }
}