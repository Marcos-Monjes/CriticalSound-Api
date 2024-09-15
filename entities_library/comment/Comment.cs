using entities_library.login;
using entities_library.ban;
using entities_library.report;
namespace entities_library.comment;

public class Comment
{
    public long Id { get; set; }

    public required string Text { get; set; }

    public required User User { get; set; } 

    public required UserBan UserBan { get; set; } //si esta activo o no
    public required ReportUser ReportUser { get; set; } //preguntar si este es posible o el de report comun
    public DateTime Date { get; set; }  //ver

}