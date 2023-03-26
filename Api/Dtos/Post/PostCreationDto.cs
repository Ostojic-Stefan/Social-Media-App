namespace Api.Dtos.Post
{
    public class PostCreationDto
    {
        public string Title { get; set; } = string.Empty;
        public string Body { get; set; } = string.Empty;
        public Guid SubId { get; set; }
    }
}