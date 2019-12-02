using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CFHentaiAPI
{
    public partial class CategoriesModel
    {
        [JsonProperty("anime")]
        public Uri Anime { get; set; }

        [JsonProperty("baguette")]
        public Uri Baguette { get; set; }

        [JsonProperty("dva")]
        public Uri Dva { get; set; }

        [JsonProperty("hentai")]
        public Uri Hentai { get; set; }

        [JsonProperty("hug")]
        public Uri Hug { get; set; }

        [JsonProperty("trap")]
        public Uri Trap { get; set; }

        [JsonProperty("nsfwneko")]
        public Uri Nsfwneko { get; set; }

        [JsonProperty("neko")]
        public Uri Neko { get; set; }

        [JsonProperty("yuri")]
        public Uri Yuri { get; set; }
    }

    public partial class CategoriesModel
    {
        public static CategoriesModel FromJson(string json) => JsonConvert.DeserializeObject<CategoriesModel>(json, Converter.Settings);
    }  
}