using jwt_auth.Interfaces;

namespace jwt_auth.Reposistories
{
    public class BcryptPasswordHasher : IPasswordHasher
    {
        public string HasPassword(string password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password);
        }
    }
}