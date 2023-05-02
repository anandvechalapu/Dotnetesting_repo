using Dotnetcom.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dotnetcom
{
    public class UserStoryRepository : IUserStoryRepository
    {
        public async Task<UserStoryModel> GetUserStory(int id)
        {
            // Get user story by id
            return await Task.FromResult(new UserStoryModel());
        }

        public async Task<List<UserStoryModel>> GetAllUserStories()
        {
            // Get all user stories
            return await Task.FromResult(new List<UserStoryModel>());
        }

        public async Task<UserStoryModel> AddUserStory(UserStoryModel model)
        {
            // Validate input
            if (!model.Validate())
            {
                return null;
            }
            
            // Add user story
            return await Task.FromResult(new UserStoryModel());
        }

        public async Task<UserStoryModel> UpdateUserStory(UserStoryModel model)
        {
            // Validate input
            if (!model.Validate())
            {
                return null;
            }
            
            // Update user story
            return await Task.FromResult(new UserStoryModel());
        }

        public async Task<UserStoryModel> DeleteUserStory(int id)
        {
            // Delete user story
            return await Task.FromResult(new UserStoryModel());
        }
    }
}