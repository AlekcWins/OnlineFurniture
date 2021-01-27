using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFurniture.Domain.DB;

namespace OnlineFurniture.Controllers
{
    public class ImageController : Controller
    {
        ApplicationDbContext _context;
        IWebHostEnvironment _appEnvironment;

        public ImageController(ApplicationDbContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }


        [HttpPost]
        [Route("uploadImage")]
        public async Task<IActionResult> AddFile(IFormFile uploadedFile)
        {
            if (uploadedFile != null)
            {
                string path = "/Files/" + uploadedFile.FileName;
                // сохраняем файл в папку Files в каталоге wwwroot
                using (var fileStream = new FileStream(_appEnvironment.WebRootPath + path, FileMode.Create))
                {
                    await uploadedFile.CopyToAsync(fileStream);
                }
                // FileModel file = new FileModel { Name = uploadedFile.FileName, Path = path };
                // _context.Files.Add(file);
                // _context.SaveChanges();

                return Ok();
            }

            return BadRequest();
        }


        [HttpGet]
        [Route("getImage/{url}")]
        public async Task<IActionResult> Get(string url)
        {
            var image = System.IO.File.OpenRead(_appEnvironment.WebRootPath + "/Files/" + url);
            return File(image, "image/jpeg");

        }
    }
}