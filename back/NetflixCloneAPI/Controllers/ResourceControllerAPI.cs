using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Interfaces;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using NetflixCloneAPI.Services;
using static NetflixCloneAPI.Interfaces.Iresource;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/resource")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class ResourceControllerAPI : ControllerBase
    {
        private BaseRepository<Resource> _resourceRepository;
        private IResource _resourceService;

        public ResourceControllerAPI(BaseRepository<Resource> resourceRepository, IResource resourceService)
        {
            _resourceRepository = resourceRepository;
            _resourceService = resourceService;
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
            return Ok(_resourceService.GetResourcesByCategorie(id));
        }

        [HttpPost]
        [Authorize("admin")]
        public IActionResult Post(ResourceDTO newResourceDTO)
        {
            bool createNewResource = _resourceService.CreateResource(newResourceDTO);
            if (createNewResource)
            {
                return Ok($"Resource successfully created!");
            }
            else
            {
                return BadRequest("Resource creation error!");
            }
        }
    }
}
