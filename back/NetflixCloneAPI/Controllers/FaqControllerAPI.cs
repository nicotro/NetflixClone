using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetflixCloneAPI.Models;
using NetflixCloneAPI.Repositories;

namespace NetflixCloneAPI.Controllers
{
    [Route("api/v1/faq")]
    [ApiController]
    [EnableCors("AllowAll")]
    public class FaqControllerAPI : ControllerBase
    {
        private BaseRepository<Faq> _FaqRepository;

        public FaqControllerAPI(BaseRepository<Faq> faqRepository)
        {
            _FaqRepository = faqRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_FaqRepository.FindAll(f=>true));
        }
    }
}
