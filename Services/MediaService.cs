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
            Console.WriteLine(filePath);
            mediaInfos.Add(new MediaInfo { Name = Path.GetFileName(filePath), PathToFile = filePath });
        }

        return mediaInfos;
    }

    public async Task<FileStream> StreamMedia(string path)
    {
        throw new NotImplementedException();
    }
}