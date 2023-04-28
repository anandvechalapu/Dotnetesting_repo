namespace Dotnetcom.Service
{
    using Dotnetcom.DataAccess;
    using Dotnetcom.DTO;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public class SharedUpsiListService : ISharedUpsiListService
    {
        private readonly SharedUpsiListRepository _sharedUpsiListRepo;

        public SharedUpsiListService(SharedUpsiListRepository sharedUpsiListRepo)
        {
            _sharedUpsiListRepo = sharedUpsiListRepo;
        }

        public async Task<IEnumerable<SharedUpsiListModel>> GetAllAsync()
        {
            return await _sharedUpsiListRepo.GetAllAsync();
        }

        public async Task<SharedUpsiListModel> GetByIdAsync(int id)
        {
            return await _sharedUpsiListRepo.GetByIdAsync(id);
        }

        public async Task<int> CreateAsync(SharedUpsiListModel model)
        {
            return await _sharedUpsiListRepo.CreateAsync(model);
        }

        public async Task UpdateAsync(SharedUpsiListModel model)
        {
            await _sharedUpsiListRepo.UpdateAsync(model);
        }

        public async Task DeleteAsync(int id)
        {
            await _sharedUpsiListRepo.DeleteAsync(id);
        }
    }

    public interface ISharedUpsiListService
    {
        Task<IEnumerable<SharedUpsiListModel>> GetAllAsync();
        Task<SharedUpsiListModel> GetByIdAsync(int id);
        Task<int> CreateAsync(SharedUpsiListModel model);
        Task UpdateAsync(SharedUpsiListModel model);
        Task DeleteAsync(int id);
    }
}