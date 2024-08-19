using entities_library.login;
using entities_library.reactions;



namespace entities_library.comment;

public class Comment
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public required User User { get; set; } 

    public DateTime Date { get; set; }  

    public required Reaction Reaction { get; set; }  

}