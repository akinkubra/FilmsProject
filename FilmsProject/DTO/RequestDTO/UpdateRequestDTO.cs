using System.Runtime.Serialization;

namespace FilmsProject.DTO.RequestDTO
{
    [DataContract]
    public class UpdateRequestDTO
    {
        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public int CategoryId { get; set; }

        [DataMember]
        public int UserId { get; set; }
    }
}
