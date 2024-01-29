using email_mailkit_smtp.Dto;
using email_mailkit_smtp.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace email_mailkit_smtp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {

        private readonly IEmailRepository _emailRepo;
        private readonly ILogger<EmailController> _logger;

        public EmailController(IEmailRepository emailRepo, ILogger<EmailController> logger)
        {
            _emailRepo = emailRepo;
            _logger = logger;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDto emailDto)
        {
            try
            {
                _emailRepo.SendEmail(emailDto);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                throw;
            }

            return Ok();
        }
    }
}