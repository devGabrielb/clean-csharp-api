using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeGym.Core.Entities;

namespace AwesomeGym.Core.Interfaces.Repositories
{
    public interface IUnidadeRepository
    {
        Task<int> Adicionar(Unidade unidade);
        Task<List<Unidade>> ObterTodos();
        Task<Unidade> ObterPorId(int id);
    }
}