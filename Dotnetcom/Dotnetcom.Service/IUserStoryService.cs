using Dotnetcom.DataAccess;
using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IUserStoryService
    {
        Task<UserStoryDTO> GetUserStory(int id);
        Task<List<UserStoryDTO>> GetAllUserStories();
        Task<UserStoryDTO> AddUserStory(UserStoryDTO model);
        Task<UserStoryDTO> UpdateUserStory(UserStoryDTO model);
        Task<UserStoryDTO> DeleteUserStory(int id);
    }
}