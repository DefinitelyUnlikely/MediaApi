using MediaApi.Models;

namespace MediaApi.Interfaces;

public interface IMediaService
{
    public Task<List<MediaMeta>> GetAllMediaMetaAsync();
    public Task<FileStream> StreamMedia(string path);
}