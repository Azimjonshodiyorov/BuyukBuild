using Microsoft.AspNetCore.Http;

namespace BuyukBuild.Domain.DataTransferObjects.StaticFileDto
{
    public record FileDto(
        IFormFile fromFile,
        string fileName);
}
