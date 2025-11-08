namespace MediaApi.Models;

public class MediaMeta
{
    public required string Name { get; set; }
    public required string PathToFile { get; set; }
    public TimeSpan? Length { get; set; }
}