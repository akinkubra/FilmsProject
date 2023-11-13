using FilmProject.Entities.Base;

using FilmsProject.Entities.Base;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace FilmProject.Entities
{
    [Table("Films")]
    public class Film: TrackableEntityBase<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [JsonIgnore]
        public virtual Category Category { get; protected set; }
    }
}
