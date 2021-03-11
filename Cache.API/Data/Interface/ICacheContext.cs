using StackExchange.Redis;

namespace Cache.API.Data.Interface
{
    public interface ICacheContext
    {
        IDatabase Redis { get; }
    }
}
