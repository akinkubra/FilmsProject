using FilmsProject.Enum;

using System.Runtime.Serialization;

namespace FilmsProject.DTO.Base
{
    [DataContract]
    public class ResponseHeader
    {
        [DataMember]
        public int Status { get; set; }

        [DataMember]
        public string Message { get; set; }

        public ResponseHeader()
        {
            this.Status = (int)ResponseStatus.Success;
        }
    }
}
