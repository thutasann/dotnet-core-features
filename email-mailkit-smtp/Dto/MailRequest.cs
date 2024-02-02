namespace email_mailkit_smtp.Dto
{
    public class MailRequest
    {
        public required string ToEmail { get; set; }
        public required string Subject { get; set; }
        public required string Body { get; set; }
        public required List<IFormFile> Attachments { get; set; }
    }
}