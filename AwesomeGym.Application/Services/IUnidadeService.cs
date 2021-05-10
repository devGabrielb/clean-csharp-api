using System.Collections.Generic;
using System.Threading.Tasks;
using AwesomeGym.Application.InputModels;
using AwesomeGym.Application.ViewModels;

namespace AwesomeGym.Application.Services
{
    public interface IUnidadeService
    {
        Task<int> Adicionar(UnidadeInputModel unidadeInputModel);
        Task<List<UnidadeItemViewModel>> ObterTodos();
        Task<UnidadeViewModel> ObterPorId(int id);
    }
}