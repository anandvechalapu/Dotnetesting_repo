using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface ISharedUpsiListRepository
    {
        Task<IEnumerable<SharedUpsiListModel>> GetAllAsync();
        Task<SharedUpsiListModel> GetByIdAsync(int id);
        Task<int> CreateAsync(SharedUpsiListModel model);
        Task UpdateAsync(SharedUpsiListModel model);
        Task DeleteAsync(int id);
    }
}