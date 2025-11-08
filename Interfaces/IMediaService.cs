using MediaApi.Models;

namespace MediaApi.Interfaces;

public interface IMediaService
{
    public Task<List<MediaInfo>> GetAllMediaInfoAsync();
    public Task<FileStream> StreamMedia(string path);
}