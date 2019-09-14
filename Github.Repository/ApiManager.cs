using System;
using System.Collections.Generic;
using System.Text;

namespace Github.Repository
{
    public enum TimePeriod
    {
        daily,
        weekly,
        monthly
    }
    public  class ApiManager
    {
        private static ApiManager _instance;
        private static readonly object _lock;
        private ApiManager() { }
        public static ApiManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new ApiManager();
                    }
                }
                return _instance;
            }
        }

        private readonly string _trendingBaseUrl= "https://github-trending-api.now.sh/";
        private readonly string _developer = "developers";
        private readonly string _repos = "repositories";
        private readonly string _language = "?language=";
        private readonly string _since = "&since=";

        public readonly string Token = "4827293739d6f6b33bf1374708b8e8b6f2cb3b7b";

        public string TrendingReposEndpoint(string language, TimePeriod since = TimePeriod.daily) => 
            _trendingBaseUrl +_repos+_language+ language + _since + since.ToString();

        public string TrendingDevelopersEndpoint(string language, TimePeriod since = TimePeriod.daily) =>
             _trendingBaseUrl + _developer + _language + language + _since + since.ToString();
    }
}
