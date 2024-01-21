using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_auth.Models.Responses
{
    public class ErrorResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; }

        public ErrorResponse(IEnumerable<string> errorMessages)
        {
            ErrorMessages = errorMessages;
        }
    }
}