using FilmsProject.DTO.RequestDTO;
using FilmsProject.DTO.ResponseDTO;

namespace FilmsProject.Services
{
    public interface IFilmService
    {
        GetAllFilmsResponseDTO GetAllFilms();
        GetFilmByIdResponseDTO GetFilmById(int filmId);
        AddFilmResponseDTO AddFilm(AddFilmRequestDTO request);
        UpdateResponseDTO Update(int filmId, UpdateRequestDTO request);
        DeleteResponseDTO Delete(int FilmId);
    }
}
