using RedisCache.Application.Services.Interfaces;
using StackExchange.Redis;

namespace RedisCache.Application.Services
{
    public class RedisCacheService : ICacheService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisCacheService(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        public async Task<string> Get(string key)
        {
            var cacheDb = _connectionMultiplexer.GetDatabase();

            return await cacheDb.StringGetAsync(key);
        }

        public async Task<bool> Set(string key, string value)
        {
            var cacheDb = _connectionMultiplexer.GetDatabase();

            return await cacheDb.StringSetAsync(key, value);
        }
    }
}
