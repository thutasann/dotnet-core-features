using System.Diagnostics;

namespace Mango.Services.CouponAPI.Middleware
{
    /// <summary>
    /// API response time Middleware
    /// </summary>
    public class ResponseTimeMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ResponseTimeMiddleware> _logger;

        public ResponseTimeMiddleware(RequestDelegate next, ILogger<ResponseTimeMiddleware> logger)
        {
            _next = next ?? throw new ArgumentNullException(nameof(next));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Invoke(HttpContext context)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            await _next(context);

            stopwatch.Stop();
            var responseTime = stopwatch.ElapsedMilliseconds;

            _logger.LogInformation($"API Response Time: {responseTime} ms");
        }
    }
}