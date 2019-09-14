using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.NewsModels.Repos
{
    public class Author
    {
        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("href")]
        public string Href { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }
    }
}
