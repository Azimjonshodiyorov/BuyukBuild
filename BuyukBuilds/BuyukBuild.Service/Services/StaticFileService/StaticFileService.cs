using BuyukBuild.Domain.DataTransferObjects.StaticFileDto;
using BuyukBuild.Domain.Entities.StaticFiles;
using BuyukBuild.Domain.Exceptions;
using BuyukBuild.Infrastructure.Repositories.Interfaces;
using BuyukBuild.Service.Services.StaticFileService.Interface;
using Microsoft.EntityFrameworkCore;

namespace BuyukBuild.Service.Services.StaticFileService
{
    public class StaticFileService : IStaticFileService
    {
        private readonly IStaticFileRepository fileRepository;

        public StaticFileService(IStaticFileRepository fileRepository)
        {
            this.fileRepository = fileRepository;
        }
        public async Task<StaticFileDto> AddStaticFileAsync(FileDto file)
        {
            var filePath = Guid.NewGuid() + Path.GetExtension(file.fromFile.Name);
            var fieldName = file.fileName;
            if(fieldName.Length == 0)
            {
                fieldName = "temp";
            }

            var path = Path.Combine(Directory.GetCurrentDirectory() , "wwwroot", filePath);

            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            path = Path.Combine(path, filePath);

            var staticFile = new StaticFile()
            {
                Path = path,
                Url = $"{fieldName}/{filePath}",
                FileExtension = Path.Combine(file.fromFile.Name),
                Size = file.fromFile.Length,
            };

            await using Stream fileStream = new FileStream(path, FileMode.Create);
            await file.fromFile.CopyToAsync(fileStream);

            staticFile = await this.fileRepository.AddAsync(staticFile);

            return new StaticFileDto(staticFile.Id, staticFile.Url);

        }

        public async Task<StaticFileDto> RemoveStaticFileAsync(RemoveFileDto removeFile)
        {
            var staticFile = await this.fileRepository.GetAllAsQueryable()
                .FirstOrDefaultAsync(x => x.Url == removeFile.filePath);
            var path = Path.Combine(Directory.GetCurrentDirectory(), staticFile!.Path);

            if(staticFile == null && staticFile.Id == 0)
            {
                if(File.Exists(path))
                {
                    File.Delete(path);
                }

                throw new NotFoundException($"Static File Not found by url: {removeFile.filePath}");
            }

            if(File.Exists(path))
            {
                File.Delete(path);
            }

            await this.fileRepository.RemoveAsync(staticFile);

            return new StaticFileDto(staticFile.Id , staticFile.Url);
        }
    }
}
