using FilmProject.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FilmProject.Entities
{
    [Table("Categories")]
    public class Category: EntityBase<int>
    {
        [Required]
        public string CategoryName { get; set; }

    }
}
