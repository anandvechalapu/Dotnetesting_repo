using Dotnetcom.Repositories;
using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface ISharedUpsiListRepository
    {
        Task<SharedUpsiListModel> GetByIdAsync(int id);
        Task<IEnumerable<SharedUpsiListModel>> GetAllAsync();
        Task<SharedUpsiListModel> AddAsync(SharedUpsiListModel model);
        Task<SharedUpsiListModel> UpdateAsync(SharedUpsiListModel model);
        Task DeleteAsync(int id);
    }
}