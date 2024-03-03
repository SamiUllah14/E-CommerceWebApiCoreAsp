using System.Net;

namespace E_CommerceApi.Models
{
    public class ApiResponse
    {
        public HttpStatusCode StatusCode { get; set; }
         public bool IsSuccess { get; set; }

        public List<string> ErrorMessages{ get; set; }

        public object Results { get; set; }
    }
}
