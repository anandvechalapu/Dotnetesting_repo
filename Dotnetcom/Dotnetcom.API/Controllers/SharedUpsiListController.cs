namespace Dotnetcom.API
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Dotnetcom.DTO;
    using Dotnetcom.Service;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class SharedUpsiListController : ControllerBase
    {
        private readonly SharedUpsiListService _service;

        public SharedUpsiListController(SharedUpsiListService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SharedUpsiListModel>>> Get()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<SharedUpsiListModel>> GetById(int id)
        {
            var model = await _service.GetByIdAsync(id);
            if (model == null)
            {
                return NotFound();
            }

            return Ok(model);
        }

        [HttpPost]
        public async Task<ActionResult<SharedUpsiListModel>> Create(SharedUpsiListModel model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.AddAsync(model);
            return CreatedAtAction(nameof(GetById), new { id = result.Id }, result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<SharedUpsiListModel>> Update(int id, SharedUpsiListModel model)
        {
            if (id != model.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = await _service.UpdateAsync(model);
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            await _service.DeleteAsync(id);
            return NoContent();
        }
    }
}