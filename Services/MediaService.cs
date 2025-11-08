using MediaApi.Interfaces;
using MediaApi.Models;

namespace MediaApi.Services;

public class MediaService : IMediaService
{
    public Task<List<MediaMeta>> GetAllMediaMetaAsync()
    {
        throw new NotImplementedException();
    }

    public Task<FileStream> StreamMedia(string path)
    {
        throw new NotImplementedException();
    }
}