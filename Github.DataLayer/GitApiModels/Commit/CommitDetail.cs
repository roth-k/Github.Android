using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
    public class CommitDetail
    {

        [JsonProperty("author")]
        public Author Author { get; set; }

        [JsonProperty("committer")]
        public Committer Committer { get; set; }

        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("tree")]
        public Tree Tree { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("comment_count")]
        public int CommentCount { get; set; }

        [JsonProperty("verification")]
        public Verification Verification { get; set; }
    }
}
