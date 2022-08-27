using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/genre")]
    [ApiController]
    [EnableCors("AllowAll")]

    public class GenreControllerAPI:ControllerBase
    {
        private BaseRepository<Genre> _genreRepository;

        public GenreControllerAPI(BaseRepository<Genre> genreRepository)
        {
            _genreRepository = genreRepository;
        }

        [HttpGet]
        [Authorize("users")]

        public IActionResult Get()
        {
            return Ok(_genreRepository.FindAll(c => true));
        }
    }
}
