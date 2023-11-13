using Azure;

using FilmsProject.DTO.RequestDTO;
using FilmsProject.DTO.ResponseDTO;
using FilmsProject.Services;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilmsProject.Controllers
{
    [Route("api/movies")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService filmService;

        /// <summary>
        /// Initializes a new instance of the <see cref="FilmController"/> class.
        /// </summary>
        /// <param name="filmService">The film service.</param>
        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        /// <summary>
        /// Get all movies
        /// </summary>
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<GetAllFilmsResponseDTO> GetAll()
        {
            GetAllFilmsResponseDTO filmList = filmService.GetAllFilms();

            return new JsonResult(filmList);
        }

        /// <summary>
        /// Get movie by id
        /// Movie id is required, please enter valid movie id
        /// Please enter valid movie id
        /// </summary>
        [Route("{id}")]
        [HttpGet]
        [Produces("application/json")]
        public ActionResult<GetFilmByIdResponseDTO> GetFilmById(int id)
        {
            GetFilmByIdResponseDTO film = filmService.GetFilmById(id);

            return new JsonResult(film);
        }

        /// <summary>
        /// Add movie with given informations
        /// CategoryId 1 is Action
        /// CategoryId 2 is Comedy
        /// CategoryId 3 is Horror
        /// CategoryId 4 is Science Fiction
        /// CategoryId 5 is Western
        /// CategoryId 6 is Love
        /// UserId 1 is corresponnd to kpoyraz
        /// Movie name is required
        /// CategoryId is required
        /// Please enter valid categoryId
        /// userId is required
        /// Please enter valid userId
        /// </summary>
        [HttpPost]
        [Produces("application/json")]
        public ActionResult<AddFilmResponseDTO> AddFilm([FromBody] AddFilmRequestDTO request)
        {
            AddFilmResponseDTO film = filmService.AddFilm(request);

            return new JsonResult(film);
        }

        /// <summary>
        /// Update movie with given id and informations 
        /// CategoryId 1 is Action
        /// CategoryId 2 is Comedy
        /// CategoryId 3 is Horror
        /// CategoryId 4 is Science Fiction
        /// CategoryId 5 is Western
        /// CategoryId 6 is Love
        /// UserId 1 is corresponnd to kpoyraz
        /// Movie id is required, please enter valid movie id
        /// Please enter valid movie id
        /// Please enter valid categoryId
        /// userId is required
        /// Please enter valid userId
        /// </summary>
        [Route("{id}")]
        [HttpPut]
        [Produces("application/json")]
        public ActionResult<UpdateResponseDTO> UpdateFilm(int id, [FromBody] UpdateRequestDTO request)
        {
            UpdateResponseDTO response = filmService.Update(id,request);

            return new JsonResult(response);
        }

        /// <summary>
        /// Delete movie with given id 
        /// Movie id is required, please enter valid movie id
        /// Please enter valid movie id
        /// </summary>
        [Route("{id}")]
        [HttpDelete]
        [Produces("application/json")]
        public ActionResult<DeleteResponseDTO> DeleteFilm(int id)
        {
            DeleteResponseDTO response = filmService.Delete(id);

            return new JsonResult(response);
        }
    }
}
