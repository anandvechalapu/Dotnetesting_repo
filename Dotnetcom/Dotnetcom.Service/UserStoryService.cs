using Dotnetcom.DataAccess;
using Dotnetcom.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dotnetcom.Service
{
    public class UserStoryService : IUserStoryService
    {
        private readonly IUserStoryRepository _userStoryRepository;

        public UserStoryService(IUserStoryRepository userStoryRepository)
        {
            _userStoryRepository = userStoryRepository;
        }

        public async Task<UserStoryDTO> GetUserStory(int id)
        {
            var userStory = await _userStoryRepository.GetUserStory(id);

            return userStory.ToDTO();
        }

        public async Task<List<UserStoryDTO>> GetAllUserStories()
        {
            var userStories = await _userStoryRepository.GetAllUserStories();
            var result = new List<UserStoryDTO>();

            foreach (var userStory in userStories)
            {
                result.Add(userStory.ToDTO());
            }

            return result;
        }

        public async Task<UserStoryDTO> AddUserStory(UserStoryDTO model)
        {
            var userStory = model.ToModel();

            // Validate input
            if (!userStory.Validate())
            {
                return null;
            }
            
            // Add user story
            var result = await _userStoryRepository.AddUserStory(userStory);

            return result.ToDTO();
        }

        public async Task<UserStoryDTO> UpdateUserStory(UserStoryDTO model)
        {
            var userStory = model.ToModel();

            // Validate input
            if (!userStory.Validate())
            {
                return null;
            }
            
            // Update user story
            var result = await _userStoryRepository.UpdateUserStory(userStory);

            return result.ToDTO();
        }

        public async Task<UserStoryDTO> DeleteUserStory(int id)
        {
            // Delete user story
            var result = await _userStoryRepository.DeleteUserStory(id);

            return result.ToDTO();
        }
    }
}