namespace MediaApi.Models;

public class MediaInfo
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string PathToFile { get; set; }
    public TimeSpan? Length { get; set; }
}