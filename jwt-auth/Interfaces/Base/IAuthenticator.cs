using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using jwt_auth.Dto.response;
using jwt_auth.Models;

namespace jwt_auth.Interfaces
{
    public interface IAuthenticator
    {
        Task<AuthenticatedUserResponse> Authenticate(User user);
    }
}