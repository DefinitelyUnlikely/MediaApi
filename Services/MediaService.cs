using System.Runtime.ExceptionServices;
using MediaApi.Interfaces;
using MediaApi.Models;

namespace MediaApi.Services;

public class MediaService : IMediaService
{
    public async Task<List<MediaInfo>> GetAllMediaInfoAsync()
    {
        List<MediaInfo> mediaInfos = [];
        foreach (string filePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory() + "/Media"))
        {
            mediaInfos.Add(new MediaInfo { Name = Path.GetFileName(filePath), PathToFile = filePath });
        }

        return mediaInfos;
    }

    public Task<string> GetPathByid(int id)
    {
        throw new NotImplementedException();
    }

    public async Task<FileStream?> StreamMedia(string path)
    {
        if (!File.Exists(path))
        {
            throw new FileNotFoundException("No file at that path");
        }

        return new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.Read);
    }

    public Task<FileStream?> StreamMedia(int id)
    {
        throw new NotImplementedException();
    }
}