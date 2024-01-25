namespace jwt_auth.Interfaces
{
    public interface IRefreshTokenGenerator
    {
        string GenerateToken();
    }
}