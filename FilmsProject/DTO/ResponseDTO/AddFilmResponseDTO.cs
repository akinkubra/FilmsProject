using Azure.Core;
using Azure;

using FilmsProject.DTO.Base;

using System.Runtime.Serialization;
using FilmProject.Entities;
using Microsoft.OpenApi.Extensions;

namespace FilmsProject.DTO.ResponseDTO
{
    [DataContract]
    public class AddFilmResponseDTO: ResponseDTOBase
    {
        [DataMember]
        public FilmDTO Film { get; set; }

        public void Fill(Film film)
        {
            this.Film = new FilmDTO()
            {
                Id = film.Id,
                Name = film.Name,
                CategoryId = film.CategoryId,
                CategoryName = film.Category.CategoryName,
                CreatedOn = film.CreatedOn,
                CreatedBy = film.CreatedBy,
                IsDeleted = film.IsDeleted,
                UpdatedOn = film.UpdatedOn,
                UpdatedBy = film.UpdatedBy
            };

            this.Header.Message = "Add a new movie record";
        }
    }
}
