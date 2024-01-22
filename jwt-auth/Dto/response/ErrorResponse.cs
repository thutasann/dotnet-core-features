namespace jwt_auth.Dto.response
{
    public class ErrorResponse
    {
        public IEnumerable<string> _errorMessages { get; set; }

        public ErrorResponse(string errorMessage) : this(new List<string>() { errorMessage })
        {

        }

        public ErrorResponse(IEnumerable<string> errorMessages)
        {
            _errorMessages = errorMessages;
        }
    }
}