using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Interfaces;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;
using static NetflixCloneAPI.Interfaces.Iresource;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/genre")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class GenreControllerAPI : ControllerBase
    {
        private BaseRepository<Genre> _genreRepository;
        private IResource _resourceService;


        public GenreControllerAPI(BaseRepository<Genre> genreRepository, IResource resourceService)
        {
            _genreRepository = genreRepository;
            _resourceService = resourceService;
        }

        [HttpGet]
        [Authorize("users")]
        public IActionResult Get()
        {
            return Ok(_genreRepository.FindAll(g => true));
        }

        [HttpGet("{id}")]
        [Authorize("users")]
        public IActionResult GetGenreByCategory(int id)
        {
            return Ok(_resourceService.GetGenresByCategory(id));
        }

    }
}
