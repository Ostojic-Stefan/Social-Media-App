using Api.Dtos.Sub;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class SubController : BaseApiController
    {
        private readonly AppDbContext _context;

        public SubController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<Sub>> CreateSub(SubCreationDto subCreationDto)
        {
            var sub = new Sub()
            {
                Name = subCreationDto.Name,
                Description = subCreationDto.Description,
                Title = subCreationDto.Title
            };
            _context.Add(sub);
            await _context.SaveChangesAsync();
            
            return Ok(sub);
        }
    }
}