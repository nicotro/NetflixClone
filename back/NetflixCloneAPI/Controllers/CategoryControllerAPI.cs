using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/category")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class CategoryControllerAPI : ControllerBase
    {
        private BaseRepository<Category> _categoryRepository;

        public CategoryControllerAPI(BaseRepository<Category> categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        [Authorize("users")]

        public IActionResult Get()
        {
            return Ok(_categoryRepository.FindAll(c => true));
        }

    }
}
