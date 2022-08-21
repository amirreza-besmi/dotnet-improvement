using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace dotnet_improvement.Core.Services
{
    public interface INewsService
    {
        // Methods
        List<string> GetAllTitles();
    }

    public class NewsService : INewsService
    {
        private readonly string _newsTitlesCacheKey = "NewsTitles";
        private readonly MemoryCacheEntryOptions _memoryCacheEntryOptions;

        private readonly IMemoryCache _memoryCache;

        NewsService(IMemoryCache memoryCache)
        {
            _memoryCacheEntryOptions = new MemoryCacheEntryOptions()
                .SetSlidingExpiration(TimeSpan.FromSeconds(20))
                .RegisterPostEvictionCallback(RemoveCallback);
            _memoryCache = memoryCache;
        }

        public List<string> GetAllTitles()
        {
            return GetOrSetNewsTitlesCachedData();
        }

        #region Private Methods

        private List<string> GetOrSetNewsTitlesCachedData()
        {
            List<string> newsTitles;
            if (!_memoryCache.TryGetValue(_newsTitlesCacheKey, out newsTitles))
            {
                newsTitles = GetNewsTitles();
                _memoryCache.Set(_newsTitlesCacheKey, newsTitles, _memoryCacheEntryOptions);
            }
            return newsTitles;
        }

        private List<string> GetOrCreateNewsTitlesCachedData()
        {
            List<string> newsTitles = _memoryCache.GetOrCreate(_newsTitlesCacheKey, p =>
            {
                p.SetSlidingExpiration(TimeSpan.FromSeconds(20));

                return GetNewsTitles();
            });
            return newsTitles;
        }

        private async Task<List<string>> GetOrCreateNewsTitlesCachedDataAsync()
        {
            List<string> newsTitles = await _memoryCache.GetOrCreateAsync(_newsTitlesCacheKey, p =>
            {
                p.SetSlidingExpiration(TimeSpan.FromSeconds(20));

                return Task.FromResult(GetNewsTitles());
            });
            return newsTitles;
        }

        private void RemoveNewsTitlesCachedData()
        {
            _memoryCache.Remove(_newsTitlesCacheKey);
        }

        private static void RemoveCallback(object key, object value, EvictionReason reason,
                                           object state)
        {
            Console.WriteLine("News titles cache removed");
        }

        private List<string> GetNewsTitles()
        {
            var titles = new List<string>()
            {
                "Election started",
                "Weather degree increased"
            };

            return titles;
        }

        #endregion
    }
}
