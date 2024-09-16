using entities_library.post;

namespace entities_library.billboard;

public class Billboard
{   
    public long BillboardId { get; set; }
    public required string Name { get; set; }
    public long PostId { get; set; }
    public required Post Post { get; set; }


    // public DateTime PublicationDate{ get; set; }
}