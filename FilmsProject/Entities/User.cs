using FilmProject.Entities.Base;

using FilmsProject.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmProject.Entities
{
    [Table("Users")]
    public class User : TrackableEntityBase<int>
    {
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string EmailAdress { get; set; }
        [Required]
        public string PhoneNumber { get; set; }

    }
}
