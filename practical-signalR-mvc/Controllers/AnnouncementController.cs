using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using practical_signalR_mvc.Hubs;


namespace practical_signalR_mvc.Controllers
{
    public class AnnouncementController : Controller
    {
        private readonly IHubContext<MessageHub> _hubContext;

        public AnnouncementController(IHubContext<MessageHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [HttpGet("/announcement")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("/announcement")]
        public async Task<IActionResult> Post([FromForm] string message)
        {
            await _hubContext.Clients.All.SendAsync("ReceiveMesssage", message);
            return RedirectToAction("Index");
        }

    }
}