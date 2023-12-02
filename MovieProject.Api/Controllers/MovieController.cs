using Microsoft.AspNetCore.Mvc;
using MovieProject.Service.Services;

namespace MovieProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieController : ControllerBase
    {
        public readonly IMovieService _movieService;

        public MovieController(IMovieService movieService)
        {
            _movieService = movieService;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            return Ok(_movieService.GetAll());
        }

        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_movieService.GetById(id));
        }

        [HttpGet]
        [Route("get/search/name/{query}")]
        public IActionResult GetByName(string query)
        {
            return Ok(_movieService.GetByName(query));
        }

        [HttpGet]
        [Route("get/search/description/{query}")]
        public IActionResult GetByDescription(string query)
        {
            return Ok(_movieService.GetByDescription(query));
        }
    }
}
