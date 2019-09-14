using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Github.Repository
{
    public class JsonDeserializer
    {
        public T Deserialize<T>(string data) =>
            JsonConvert.DeserializeObject<T>(data);
    }
}
