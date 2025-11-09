using MediaApi.Models;

namespace MediaApi.Interfaces;

public interface IMediaService
{
    public Task<Dictionary<int, string>> GetAllMediaInfoAsync();
    public Task<string> GetPathByid(int id);
    public Task<FileStream?> StreamMedia(int id);
    public Task UpdateMediaList();
}