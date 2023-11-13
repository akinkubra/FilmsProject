using FilmProject.Entities;

using FilmsProject.DTO;
using FilmsProject.DTO.Base;

using Microsoft.EntityFrameworkCore.Scaffolding.Metadata;

using System.Runtime.Serialization;

namespace FilmsProject.DTO.ResponseDTO
{
    [DataContract]
    public class GetAllFilmsResponseDTO : ResponseDTOBase
    {
        [DataMember]
        public IList<FilmDTO> Films { get; set; }

        public void Fill(IList<Film> films)
        {
            this.Films = new List<FilmDTO>();

            foreach (var film in films)
            {
                this.Films.Add(new FilmDTO()
                {
                    Id = film.Id,
                    Name = film.Name,
                    CategoryId = film.CategoryId,
                    CategoryName = film.Category.CategoryName,
                    CreatedOn = film.CreatedOn,
                    CreatedBy = film.CreatedBy,
                    IsDeleted  = film.IsDeleted,
                    UpdatedOn = film.UpdatedOn,
                    UpdatedBy = film.UpdatedBy
                });
            }

            this.Header.Message = "Get All movie records";
        }
    }
}
