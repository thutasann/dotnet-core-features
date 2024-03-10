namespace Mango.Web.Utils
{
    public class SD
    {
        public static string? CouponAPIBase { get; set; }
        public static string? AuthAPIBase { get; set; }
        public static string? ProductAPIBase { get; set; }
        public const string RoleAdmin = "ADMIN";
        public const string RoleCustomer = "CUSTOMER";
        public const string TokenCookie = "JWTToken";

        public enum ContentType
        {
            Json,
            MultipartFormData
        }
    }
}