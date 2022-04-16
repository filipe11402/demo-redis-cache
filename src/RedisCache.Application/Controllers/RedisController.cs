using Microsoft.AspNetCore.Mvc;
using RedisCache.Application.Services.Interfaces;
using RedisCache.Application.ViewModels;

namespace RedisCache.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RedisController : ControllerBase
    {
        private readonly ICacheService _cacheService;

        public RedisController(ICacheService cacheService)
        {
            _cacheService = cacheService;
        }

        [HttpGet]
        [Route("get")]
        public async Task<IActionResult> Get([FromQuery] GetCacheModel request)
        {
            var cacheString = await _cacheService.Get(request.Key);

            return cacheString == null ? StatusCode(StatusCodes.Status404NotFound) :
                StatusCode(StatusCodes.Status302Found, cacheString);
        }

        [HttpPost]
        [Route("set")]
        public async Task<IActionResult> Set([FromBody] SetCacheModel request) 
        {
            return await _cacheService.Set(request.Key, request.Value) ? StatusCode(StatusCodes.Status201Created) :
                StatusCode(StatusCodes.Status400BadRequest);
        }
    }
}
