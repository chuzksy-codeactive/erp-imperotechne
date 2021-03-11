using Cache.API.Data.Interface;
using StackExchange.Redis;

namespace Cache.API.Data
{
    public class CacheContext : ICacheContext
    {
        private readonly ConnectionMultiplexer _redisConnection;
        public CacheContext(ConnectionMultiplexer redisConnection)
        {
            _redisConnection = redisConnection;
            Redis = _redisConnection.GetDatabase();
        }

        public IDatabase Redis { get; }
    }
}
