using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnetcom.DataAccess;
using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public class SharedUpsiListService : ISharedUpsiListService
    {
        private readonly SharedUpsiListRepository _repository;

        public SharedUpsiListService(SharedUpsiListRepository repository)
        {
            _repository = repository;
        }

        public async Task<SharedUpsiListModel> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<SharedUpsiListModel>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<SharedUpsiListModel> AddAsync(SharedUpsiListModel model)
        {
            return await _repository.AddAsync(model);
        }

        public async Task<SharedUpsiListModel> UpdateAsync(SharedUpsiListModel model)
        {
            return await _repository.UpdateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}