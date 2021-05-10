using System.Threading.Tasks;

namespace AwesomeGym.Core.Interfaces.Services
{
    public interface IFileStorageService
    {
        Task AddFile(byte[] content, string fileName);

    }
}