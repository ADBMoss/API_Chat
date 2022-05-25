using System;
using System.Net.Http;
using Newtonsoft.Json.Linq;

namespace APIChat
{
    public class Quotes
    {
        private HttpClient _client;

        public Quotes(HttpClient client)
        {
            _client = client;
        }

        public string KanyeWest()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").ToString();
            string newAnswer = "";
            foreach (var item in kanyeQuote)
            {
                char answer2 = '"';
                newAnswer = kanyeQuote.Replace(answer2, ' ').Replace('}', ' ').Trim();
            }

            return newAnswer;
        }

        public string RonSwanson()
        {
            string newAnswer2 = "";
            var client2 = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client2.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString();
            foreach (var item2 in ronQuote)
            {
                char answer2 = '"';
                newAnswer2 = ronQuote.Replace(answer2, ' ').Replace('[', ' ').Replace(']', ' ').TrimStart();
            }

            return newAnswer2;
        }
    }
}
