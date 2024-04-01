using CodePulse.API.Models.Domain;

namespace CodePulse.API.Repositories.Inteface
{
    public interface IImageRepository
    {
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);
        Task<IEnumerable<BlogImage>> GetAll();
    }
}
