using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.NewsModels.Repos
{
    public class Repository
    {
        [JsonProperty("author")]
        public string Author { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("language")]
        public string Language { get; set; }

        [JsonProperty("languageColor")]
        public string LanguageColor { get; set; }

        [JsonProperty("stars")]
        public int Stars { get; set; }

        [JsonProperty("forks")]
        public int Forks { get; set; }

        [JsonProperty("currentPeriodStars")]
        public int CurrentPeriodStars { get; set; }

        [JsonProperty("builtBy")]
        public IList<Author> BuiltBy { get; set; }
    }
}
