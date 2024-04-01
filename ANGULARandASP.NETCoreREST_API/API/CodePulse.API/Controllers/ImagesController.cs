using CodePulse.API.Models.Domain;
using CodePulse.API.Models.DTO;
using CodePulse.API.Repositories.Inteface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodePulse.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImagesController : ControllerBase
    {
        private readonly IImageRepository imageRepository;

        public ImagesController(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        //POST: api/images
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file, [FromForm] string filename, [FromForm] string title)
        {
            ValidateFileUpload(file);
            if (ModelState.IsValid)
            {
                // File upload
                var blogImage = new BlogImage
                {
                    FileExtension = Path.GetExtension(file.FileName).ToLower(),
                    FileName = filename,
                    Title = title,
                    DateCreate = DateTime.Now,
                };
                blogImage = await imageRepository.Upload(file, blogImage);

                var response = new BlogImageDto
                {
                    Id = blogImage.Id,
                    Title = blogImage.Title,
                    DateCreate = DateTime.Now,
                    FileExtension = blogImage.FileExtension,
                    FileName = blogImage.FileName,
                    Url = blogImage.Url,
                };
                return Ok(response);
            }
            return BadRequest(ModelState);
        }

        private void ValidateFileUpload(IFormFile file)
        {
            var allowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
            if (!allowedExtensions.Contains(Path.GetExtension(file.FileName).ToLower()))
            {
                ModelState.AddModelError("file", "Unsupported file format");
            }
            if (file.Length > 10485760)
            {
                ModelState.AddModelError("file", "File size can not be more than 10Mb");
            }
        }

        //GET: api/images
        [HttpGet]
        public async Task<IActionResult> GetAllImage()
        {
            // call image repository to get all image
            var images = await imageRepository.GetAll();
            // convert domain model to dto
            var response = new List<BlogImageDto>();
            foreach (var image in images)
            {
                response.Add(new BlogImageDto
                {
                    Id = image.Id,
                    Title = image.Title,
                    DateCreate = DateTime.Now,
                    FileExtension = image.FileExtension,
                    FileName = image.FileName,
                    Url = image.Url,
                });
            }
            return Ok(response);
        }
    }
}
