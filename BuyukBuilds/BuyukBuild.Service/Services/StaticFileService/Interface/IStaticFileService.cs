using BuyukBuild.Domain.DataTransferObjects.StaticFileDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyukBuild.Service.Services.StaticFileService.Interface
{
    public interface IStaticFileService
    {
        Task<StaticFileDto> AddStaticFileAsync(FileDto file);
        Task<StaticFileDto> RemoveStaticFileAsync(RemoveFileDto  removeFile);
    }
}
