using System.Collections.Generic;
using System.Threading.Tasks;
using Dotnetcom.DataAccess;
using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface ISharedUpsiListService
    {
        Task<SharedUpsiListModel> GetByIdAsync(int id);
        Task<IEnumerable<SharedUpsiListModel>> GetAllAsync();
        Task<SharedUpsiListModel> AddAsync(SharedUpsiListModel model);
        Task<SharedUpsiListModel> UpdateAsync(SharedUpsiListModel model);
        Task DeleteAsync(int id);
    }
}