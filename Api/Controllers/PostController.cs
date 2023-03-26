using Api.Dtos.Post;
using Data;
using Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Api.Controllers
{
    public class PostController : BaseApiController
    {
        private readonly AppDbContext _context;

        public PostController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult<PostWithoutSubDto>> CreatePost(PostCreationDto postCreation)
        {
            var sub = await _context.Subs.FirstOrDefaultAsync(x => x.Id == postCreation.SubId);

            if (sub is null)
                return BadRequest("Sub with given ID does not exist");

            var post = new Post()
            {
                Body = postCreation.Body,
                Title = postCreation.Title,
                Sub = sub
            };

            _context.Posts.Add(post);
            await _context.SaveChangesAsync();

            var ret = new PostWithoutSubDto()
            {
                Body = post.Body,
                Comments = new List<Comment>(),
                Slug = null,
                Title = post.Title,
                User = null
            };

            return Ok(ret);
        }

        [HttpGet]
        public async Task<ActionResult<List<PostWithoutSubDto>>> GetAllPost()
        {
            var posts = await _context.Posts.ToListAsync();
            
            List<PostWithoutSubDto> list = new();

            foreach(var post in posts)
            {
                list.Add(
                    new PostWithoutSubDto()
                    {
                        Id = post.Id,
                        Body = post.Body,
                        Comments = new List<Comment>(),
                        Slug = null,
                        Title = post.Title,
                        User = null
                    }
                );
            }
            return Ok(list);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PostWithoutSubDto>> GetPost(Guid id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);

            if (post is null)
                return BadRequest($"Post with id = {id} does not exist");

            return Ok(new PostWithoutSubDto()
            {
                Id = post.Id,
                Body = post.Body,
                Comments = new List<Comment>(),
                Slug = null,
                Title = post.Title,
                User = null
            });
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Post>> UpdatePost(Guid id, PostUpdateDto postUpdateDto)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);

            if (post is null)
                return BadRequest($"Post with id = {id} does not exist");

            post.Title = postUpdateDto.Title;
            post.Body = postUpdateDto.Body;

            await _context.SaveChangesAsync();

            return Ok(post);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Post>> DeletePost(Guid id)
        {
            var post = await _context.Posts.FirstOrDefaultAsync(x => x.Id == id);

            if (post is null)
                return BadRequest($"Post with id = {id} does not exist");

            _context.Posts.Remove(post);

            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}