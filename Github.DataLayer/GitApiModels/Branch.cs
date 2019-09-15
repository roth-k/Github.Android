using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class Branch
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("commit")]
        public Tree Commit { get; set; }

        [JsonProperty("protected")]
        public bool Protected { get; set; }
    }
}
