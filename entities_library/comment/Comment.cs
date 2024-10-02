using entities_library.login;
using entities_library.ban;

namespace entities_library.comment;

public class Comment
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public required User User { get; set; } 

    public required UserBan UserBan { get; set; } //si esta activo o no
    public DateTime Date { get; set; }  //ver

}