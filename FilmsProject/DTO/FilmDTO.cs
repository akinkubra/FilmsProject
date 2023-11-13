using System.Runtime.Serialization;

namespace FilmsProject.DTO
{
    [DataContract]
    public class FilmDTO
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember] 
        public string CategoryName { get; set; }

        [DataMember]
        public DateTime CreatedOn { get; set; }

        [DataMember]
        public long CreatedBy { get; set; }

        [DataMember]
        public bool IsDeleted { get; set; }

        [DataMember]
        public DateTime? UpdatedOn { get; set; }

        [DataMember]
        public long? UpdatedBy { get; set; }

    }
}
