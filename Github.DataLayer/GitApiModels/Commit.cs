using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class Commit
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("commit")]
        public CommitDetail CommitDetail { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("committer")]
        public Committer Committer { get; set; }

        [JsonProperty("parents")]
        public IList<Parent> Parents { get; set; }
    }
}
