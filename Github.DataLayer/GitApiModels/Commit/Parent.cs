﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class Parent
    {

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }
    }
}

