using System.Runtime.ExceptionServices;
using MediaApi.Interfaces;
using MediaApi.Models;

namespace MediaApi.Services;

public class MediaService : IMediaService
{

    private readonly Dictionary<int, string> mediaPathDict = [];
    private int counter = 0;

    public Dictionary<int, string> GetAllMediaInfoAsync()
    {
        UpdateMediaList();
        return mediaPathDict;
    }

    public void UpdateMediaList()
    {
        foreach (string filePath in Directory.EnumerateFiles(Directory.GetCurrentDirectory() + "/Media"))
        {
            if (filePath[^2..].Equals("md", StringComparison.CurrentCultureIgnoreCase)) { continue; }

            if (!mediaPathDict.ContainsValue(filePath)) mediaPathDict.Add(++counter, filePath);
        }
    }

    public string GetPathByid(int id)
    {
        return mediaPathDict[id];
    }

    public FileStream? StreamMedia(int id)
    {

        if (!File.Exists(mediaPathDict[id]))
        {
            throw new FileNotFoundException("No file at that path");
        }

        return new FileStream(mediaPathDict[id], FileMode.Open, FileAccess.Read, FileShare.Read);
    }


}