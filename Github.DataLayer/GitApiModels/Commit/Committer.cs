using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class Committer
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("date")]
        public DateTime Date { get; set; }
    }
}
