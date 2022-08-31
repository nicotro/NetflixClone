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

        // Get all resources from one category
        [HttpGet("{categoryId}")]
        [Authorize("users")]
        public IActionResult Get(int categoryId)
        {
            return Ok(_resourceService.GetResourcesByCategory(categoryId));
        }

        // Get one resource from one category
        [HttpGet("{categoryId}/{id}")]
        [Authorize("users")]
        public IActionResult Get(int categoryId, int id)
        {
            ResourceDTO resourceDTO = _resourceService.GetSingleResourceByCategory(categoryId, id);
            if (resourceDTO != null)
            {
                return Ok(resourceDTO);
            }
            else
            {
                return BadRequest("No resource found!");
            }
        }


        // Get all resources from one category & one genre
        [HttpGet("rg/{categoryId}/{genreId}")]
        [Authorize("users")]
        public IActionResult GetByGenre(int categoryId, int genreId)
        {
            return Ok(_resourceService.GetResourcesByGenre(categoryId, genreId));
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
