using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CFHentaiAPI
{
    public partial class ContentModel
    {
        [JsonProperty("url")]
        public Uri Url { get; set; }
    }

    public partial class ContentModel
    {
        public static ContentModel FromJson(string json) => JsonConvert.DeserializeObject<ContentModel>(json, Converter.Settings);
    }
}