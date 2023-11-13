using System.Runtime.Serialization;

namespace FilmsProject.DTO.Base
{
    [DataContract]
    public class ResponseDTOBase
    {
        [DataMember]
        public ResponseHeader Header { get; set; }
        public ResponseDTOBase()
        {
            this.Header = new ResponseHeader();
        }
    }
}
