using Dotnetcom.DTO;

namespace Dotnetcom.Service
{
    public interface IUserStoryRepository
    {
        Task<UserStoryModel> GetUserStory(int id);
        Task<List<UserStoryModel>> GetAllUserStories();
        Task<UserStoryModel> AddUserStory(UserStoryModel model);
        Task<UserStoryModel> UpdateUserStory(UserStoryModel model);
        Task<UserStoryModel> DeleteUserStory(int id);
    }
}