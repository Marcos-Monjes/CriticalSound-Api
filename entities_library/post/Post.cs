namespace entitities_library.post;

public class Post
{
    public long Id { get; set; }

    public required string Text { get; set; }
    
    public List<Comment> Comments { get; set; } = new List<Comment>();

    public List<Raction> Ractions { get; set; } = new List<Reaction>();

    public DateTime DateTime { get; set; };

    public required User User { get; set; }

    public PostStatus PostStatus { get; set; }  
    

}