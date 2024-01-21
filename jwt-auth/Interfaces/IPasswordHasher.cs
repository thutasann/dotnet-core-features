using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jwt_auth.Interfaces
{
    public interface IPasswordHasher
    {
        string HasPassword(string password);
    }
}