using entities_library.post;

namespace entities_library.billboard;

public class Billboard
{
    public required string Name { get; set; }

    public required Post Post { get; set; }


    // public DateTime PublicationDate{ get; set; }
}