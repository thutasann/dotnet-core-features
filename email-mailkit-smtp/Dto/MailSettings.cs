namespace email_mailkit_smtp.Dto
{
    public class MailSettings
    {
        public required string Mail { get; set; }
        public required string DisplayName { get; set; }
        public required string Password { get; set; }
        public required string Host { get; set; }
        public required int Port { get; set; }
    }
}