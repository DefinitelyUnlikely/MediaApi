using MediaApi.Models;

namespace MediaApi.Interfaces;

public interface IMediaService
{
    public Dictionary<int, string> GetAllMediaInfoAsync();
    public string GetPathByid(int id);
    public FileStream? StreamMedia(int id);
    public void UpdateMediaList();
}