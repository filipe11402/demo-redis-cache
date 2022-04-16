namespace RedisCache.Application.Services.Interfaces
{
    public interface ICacheService
    {
        Task<bool> Set(string key, string value);

        Task<string> Get(string key);
    }
}
