using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Dotnetcom.DTO;
using Dotnetcom.Service;

namespace Dotnetcom.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserStoryController : ControllerBase
    {
        private readonly UserStoryService _userStoryService;

        public UserStoryController(UserStoryService userStoryService)
        {
            _userStoryService = userStoryService;
        }

        [HttpGet]
        [Route("/{id}")]
        public async Task<IActionResult> GetUserStory(int id)
        {
            var result = await _userStoryService.GetUserStory(id);
            if (result == null)
            {
                return NotFound(id);
            }

            return Ok(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUserStories()
        {
            var result = await _userStoryService.GetAllUserStories();
            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddUserStory(UserStoryDTO userStoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userStoryService.AddUserStory(userStoryDto);
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> UpdateUserStory(int id, UserStoryDTO userStoryDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _userStoryService.UpdateUserStory(userStoryDto);
            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> DeleteUserStory(int id)
        {
            var result = await _userStoryService.DeleteUserStory(id);
            if (result == null)
            {
                return NotFound(id);
            }

            return Ok(result);
        }
    }
}