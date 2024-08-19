using entities_library.login;
using entitities_library.reactions;

namespace entitities_library.comment;

public class Comment
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public required User User { get; set; } 

    public DateTime Date { get; set; }  

    public ReactionType ReactionType { get; set; }  

}