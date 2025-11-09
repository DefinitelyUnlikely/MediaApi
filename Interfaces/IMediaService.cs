using MediaApi.Models;

namespace MediaApi.Interfaces;

public interface IMediaService
{
    public Task<List<MediaInfo>> GetAllMediaInfoAsync();
    public Task<string> GetPathByid(int id);
    public Task<FileStream?> StreamMedia(int id);
}