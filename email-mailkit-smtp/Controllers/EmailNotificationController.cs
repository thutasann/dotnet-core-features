using email_mailkit_smtp.Dto;
using email_mailkit_smtp.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace email_mailkit_smtp.Controllers
{
    /// <summary>
    /// Another Example for Email Sending
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class EmailNotificationController : ControllerBase
    {
        private readonly IEmailNotificationRepository _emailRepository;
        private readonly ILogger<EmailNotificationController> _logger;

        public EmailNotificationController(IEmailNotificationRepository emailRepository, ILogger<EmailNotificationController> logger)
        {
            _emailRepository = emailRepository;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> SendEmail([FromForm] MailRequest request)
        {
            try
            {
                await _emailRepository.SendEmailAsync(request);
            }
            catch (Exception ex)
            {
                _logger.LogError("Email Send Error ", ex.Message);
            }

            return Ok();
        }
    }
}