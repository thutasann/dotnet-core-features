namespace jwt_auth.Interfaces
{
    public interface IRefreshTokenValidator
    {
        /// <summary>
        /// RefreshToken Validator
        /// </summary>
        /// <param name="refreshToken"></param>
        /// <returns></returns>
        bool Validate(string refreshToken);
    }
}