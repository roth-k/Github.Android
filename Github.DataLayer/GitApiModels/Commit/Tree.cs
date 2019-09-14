using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class Tree
    {

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}
