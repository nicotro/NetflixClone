using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/resource")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class ResourceControllerAPI : ControllerBase
    {
        private BaseRepository<Resource> _resourceRepository;

        public ResourceControllerAPI(BaseRepository<Resource> resourceRepository)
        {
            _resourceRepository = resourceRepository;
        }

        [HttpGet]
        [Authorize("users")]
        public IActionResult Get()
        {
            return Ok(_resourceRepository.FindAll(g => true));
        }

        [HttpGet("{id}")]
        [Authorize("users")]
        public IActionResult Get(int id)
        {
            return Ok(_resourceRepository.Find(g => g.Id==id));
        }

    }
}
