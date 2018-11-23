
//dotnet publish -f netcoreapp2.1 -c Release
using System;
using System.Collections.Generic;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace dk.commentor.mslearn.web
{
    [Route("api/learn/")]
    [ApiController]
    public class LeaderboardController : ControllerBase
    {
        private string blobContainerName;
        private string blobContainerConnString;
        //public LeaderboardController(IConfiguration configuration)
        public LeaderboardController()
        {

        }

        [Route("preview/{pdfGuid}"), AcceptVerbs("Get")]
        public ActionResult preview(string pdfGuid)
        {
            return null;
        }

        //[HttpPost]
        [Route("modify"), AcceptVerbs("POST")]
        public string modify([FromBody] Object documentHeader)
        {
            return null;
        }

        [Route("gamers"), AcceptVerbs("Get")]
        public List<String> getGamers()
        {
            String baseUrl = "https://docs.microsoft.com/api/gamestatus/";
            var gamerNames = new List<String>();
            gamerNames.Add("pwe");
            gamerNames.Add("jkj");
            gamerNames.Add("michaelsundgaard");
            gamerNames.Add("emilbolet");
            gamerNames.Add("anj");
            gamerNames.Add("rhe");

            var httpClient = new HttpClient();
            foreach(var gamerName in gamerNames) {
                var gamerJson = httpClient.GetStringAsync($"{baseUrl}{gamerName}").ConfigureAwait(false).GetAwaiter().GetResult();
                var gamer = JsonConvert.DeserializeObject<Gamer>(gamerJson); 
            }
            
            return null;
        }        
    }
}