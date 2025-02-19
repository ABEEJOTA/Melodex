using Melodex.Domain.Models;

public class Track
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Duration { get; set; }
    public int TrackNumber { get; set; }

    public Guid MediaItemId { get; set; }
    public MediaItem MediaItem { get; set; }  // Relación con MediaItem

    public Guid PlayListId { get; set; }
    public PlayList PlayList { get; set; }  // Relación con PlayList
}
