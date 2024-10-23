using entities_library.song;

namespace entities_library.billboard;

public class Billboard
{   
    public long BillboardId { get; set; }
    public required string Name { get; set; }
    public long SongId { get; set; }
    public required Song song { get; set; }


    // public DateTime PublicationDate{ get; set; }
}