using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.DataLayer.GitApiModels
{
   public class Verification
    {
        [JsonProperty("verified")]
        public bool Verified { get; set; }

        [JsonProperty("reason")]
        public string Reason { get; set; }

        [JsonProperty("signature")]
        public object Signature { get; set; }

        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}
