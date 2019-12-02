using System;
using System.Collections.Generic;
using System.Net;

namespace CFHentaiAPI
{
    public class CFHentai
    {
        private static CategoriesModel apiEndpoints;

        public CFHentai()
        {
            FillEndpoints();
        }

        private void FillEndpoints()
        {
            apiEndpoints = CategoriesModel.FromJson(GetJSON("https://api.computerfreaker.cf/v1/categories"));
        }

        private string GetJSON(string endpoint)
        {
            string jsonResult = "";
            using (WebClient wc = new WebClient())
            {
                jsonResult = wc.DownloadString(endpoint);
            }
            return jsonResult;
        }

        public string GetAnime()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Anime.OriginalString)).Url.OriginalString;
        }
        public string GetBaguette()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Baguette.OriginalString)).Url.OriginalString;
        }

        public string GetDVA()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Dva.OriginalString)).Url.OriginalString;
        }

        public string GetHentai()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Hentai.OriginalString)).Url.OriginalString;
        }

        public string GetHug()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Hug.OriginalString)).Url.OriginalString;
        }
        public string GetNeko()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Neko.OriginalString)).Url.OriginalString;
        }

        public string GetNaughtyNeko()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Nsfwneko.OriginalString)).Url.OriginalString;
        }
        public string GetTrap()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Trap.OriginalString)).Url.OriginalString;
        }

        public string GetYuri()
        {
            return ContentModel.FromJson(GetJSON(apiEndpoints.Yuri.OriginalString)).Url.OriginalString;
        }
    } 
}
