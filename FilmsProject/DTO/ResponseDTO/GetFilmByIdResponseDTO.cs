using Azure;

using FilmProject.Entities;

using FilmsProject.DTO.Base;

using System.Runtime.Serialization;

namespace FilmsProject.DTO.ResponseDTO
{
    [DataContract]
    public class GetFilmByIdResponseDTO: ResponseDTOBase
    {
        [DataMember]
        public FilmDTO Film { get; set; }

        public void Fill(Film film)
        {
            this.Film = new FilmDTO();

            this.Film.Id = film.Id;
            this.Film.Name = film.Name;
            this.Film.CategoryId = film.CategoryId;
            this.Film.CategoryName = film.Category.CategoryName;
            this.Film.CreatedOn = film.CreatedOn;
            this.Film.CreatedBy = film.CreatedBy;
            this.Film.IsDeleted = film.IsDeleted;
            this.Film.UpdatedOn = film.UpdatedOn;
            this.Film.UpdatedBy = film.UpdatedBy;

            this.Header.Message = "Get a movie record by ID";
        }
    }
}
