using MediaApi.Interfaces;
using MediaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace MediaApi.Controllers;

[ApiController]
[Route("[controller]")]
public class MediaController(IMediaService mediaService) : ControllerBase
{
    [HttpGet("/media")]
    public async Task<IActionResult> GetAvailableMediaMeta()
    {
        return new OkObjectResult(mediaService.GetAllMediaInfoAsync());
    }

    [HttpGet("/media/{id}")]
    public IActionResult StreamMedia(int id)
    {
        mediaService.UpdateMediaList();
        var fileStream = mediaService.StreamMedia(id);

        if (fileStream is null)
        {
            return new NotFoundObjectResult("Could not find the media file");
        }

        return File(fileStream, "video/mp4", enableRangeProcessing: true);
    }
}
