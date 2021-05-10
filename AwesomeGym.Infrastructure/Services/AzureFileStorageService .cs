using System;
using System.Threading.Tasks;
using AwesomeGym.Core.Interfaces.Services;

namespace AwesomeGym.Infrastructure.Services
{
    public class AzureFileStorageService : IFileStorageService
    {
        public Task AddFile(byte[] content, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}