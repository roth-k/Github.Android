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
        private static readonly object _lock = new object();
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

        private readonly string _gitApiBaseUrl = "https://api.github.com";
        private readonly string _user = "/users/";
        private readonly string _repo = "/repos/";

        internal readonly string Token = "6e3cfb4f01d02aba0d5be034417d602b737c33e8";

        public string TrendingReposEndpoint(string language, TimePeriod since = TimePeriod.daily) => 
            _trendingBaseUrl +_repos+_language+ language + _since + since.ToString();

        public string TrendingDevelopersEndpoint(string language, TimePeriod since = TimePeriod.daily) =>
             _trendingBaseUrl + _developer + _language + language + _since + since.ToString();

        public string GitDeveloperApiEndpoint(string username) =>
            _gitApiBaseUrl + _user + username;
        public string GitRepoApiEndpoint(string username, string reponame) =>
            _gitApiBaseUrl  +_repo + username +"/"+ reponame;
    }
}
