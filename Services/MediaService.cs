using System.Runtime.ExceptionServices;
using MediaApi.Interfaces;
using MediaApi.Models;

namespace MediaApi.Services;

public class MediaService : IMediaService
{

    private readonly Dictionary<int, string> mediaPathDict = [];
    private int counter = 0;

    public async Task<Dictionary<int, string>> GetAllMediaInfoAsync()
    {
        await UpdateMediaList();
        return mediaPathDict;
    }

    public async Task UpdateMediaList()
    {
        foreach (string filePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory() + "/Media"))
        {
            if (!mediaPathDict.ContainsValue(filePath)) mediaPathDict.Add(++counter, filePath);
        }
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