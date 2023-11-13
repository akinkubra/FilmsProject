using FilmProject.Entities;
using FilmsProject.DTO;
using FilmsProject.Repository;
using FilmsProject.Enum;
using FilmsProject.DTO.ResponseDTO;
using FilmsProject.DTO.RequestDTO;
using Azure;
using FilmsProject.Repository.Interfaces;
using System.Diagnostics.Eventing.Reader;

namespace FilmsProject.Services
{
    public class FilmService: IFilmService
    {
        private readonly IFilmRepository filmRepository;
        private readonly ICategoryRepository categoryRepository;
        private readonly IUserRepository userRepository;

        public FilmService(IFilmRepository filmRepository, ICategoryRepository categoryRepository, IUserRepository userRepository)
        {
            this.filmRepository = filmRepository;
            this.categoryRepository = categoryRepository;
            this.userRepository = userRepository;
        }


        public GetAllFilmsResponseDTO GetAllFilms()
        {
            GetAllFilmsResponseDTO response = new GetAllFilmsResponseDTO();

            IList<Film> filmList = this.filmRepository.GetAll().ToList();

            response.Fill(filmList);          

            return response;
        }

        public GetFilmByIdResponseDTO GetFilmById(int filmId)
        {
            GetFilmByIdResponseDTO response = new GetFilmByIdResponseDTO();
            try
            {
                if (filmId == 0)
                    throw new Exception("Movie id is required, please enter valid movie id");
                else
                {
                    Film film = this.filmRepository.GetSingle(filmId);

                    if (film == null)
                    {
                        throw new Exception("Please enter valid movie id");
                    }

                    response.Fill(film);
                }
            }
            catch (Exception e)
            {
                response.Header.Status = (int)ResponseStatus.Failure;
                response.Header.Message = e.Message;
            }

            return response;
        }

        public AddFilmResponseDTO AddFilm(AddFilmRequestDTO request)
        {
            AddFilmResponseDTO response = new AddFilmResponseDTO();

            try
            {
                if (string.IsNullOrWhiteSpace(request.Name))
                    throw new Exception("Movie name is required");

                if (request.CategoryId == 0)
                    throw new Exception("CategoryId is required");
                else
                {
                    var category = this.categoryRepository.GetSingle(request.CategoryId);
                    if(category == null)
                    {
                        throw new Exception("Please enter valid categoryId");
                    }
                }

                if (request.UserId == 0)
                    throw new Exception("userId is required");
                else
                {
                    var user = this.userRepository.GetSingle(request.UserId);
                    if (user == null)
                    {
                        throw new Exception("Please enter valid userId");
                    }
                }

                var newFilm = new Film()
                {
                    Name = request.Name,
                    CategoryId = request.CategoryId,
                    CreatedBy = request.UserId
                };

                this.filmRepository.Add(newFilm);
                Film film = this.filmRepository.GetSingle(newFilm.Id);
                response.Fill(film);
               
            }
            catch (Exception e)
            {
                response.Header.Status = (int)ResponseStatus.Failure;
                response.Header.Message = e.Message;
            }

            return response;
        }

        public UpdateResponseDTO Update(int filmId, UpdateRequestDTO request)
        {
            UpdateResponseDTO response = new UpdateResponseDTO();
            try
            {
                if (filmId == 0)
                    throw new Exception("Movie id is required, please enter valid movie id");
                else
                {
                    var film = this.filmRepository.GetSingle(filmId);

                    if (film == null)
                        throw new Exception("Please enter valid movie id");
                    else
                    {
                        if (!string.IsNullOrWhiteSpace(request.Name))
                            film.Name = request.Name;
                        if (request.CategoryId != 0)
                        {
                            var category = this.categoryRepository.GetSingle(request.CategoryId);
                            if (category == null)
                            {
                                throw new Exception("Please enter valid categoryId");
                            }
                            film.CategoryId = request.CategoryId;
                        }

                        if (request.UserId == 0)
                        {
                            throw new Exception("userId is required");
                        }
                        else
                        {
                            var user = this.userRepository.GetSingle(request.UserId);
                            if (user == null)
                            {
                                throw new Exception("Please enter valid userId");
                            }
                        }

                        film.UpdatedOn = DateTime.Now;
                        film.UpdatedBy = request.UserId;
                        this.filmRepository.Update(film);

                        response.Header.Message = "Update an existing movie record";
                    }
                }
            }
            catch (Exception e)
            {
                response.Header.Status = (int)ResponseStatus.Failure;
                response.Header.Message = e.Message;
            }

            return response;
        }

        public DeleteResponseDTO Delete(int filmId)
        {
            DeleteResponseDTO response = new DeleteResponseDTO();
            try
            {
                if (filmId == 0)
                    throw new Exception("Movie id is required, please enter valid movie id");
                else
                {
                    var film = this.filmRepository.GetSingle(filmId);

                    if (film == null)
                        throw new Exception("Please enter valid movie id");
                    else
                        this.filmRepository.Delete(film);

                    response.Header.Message = "Delete a movie record";
                }
            }
            catch (Exception e)
            {
                response.Header.Status = (int)ResponseStatus.Failure;
                response.Header.Message = e.Message;
            }

            return response;

        }

    }
}
