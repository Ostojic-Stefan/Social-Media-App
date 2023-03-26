using Data.Models;

namespace Api.Dtos.Post
{
    public class PostWithoutSubDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public string Slug { get; set; }
        public User User { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
