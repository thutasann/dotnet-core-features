namespace email_mailkit_smtp.Dto
{
    public class EmailDto
    {
        public required string To { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }
    }
}