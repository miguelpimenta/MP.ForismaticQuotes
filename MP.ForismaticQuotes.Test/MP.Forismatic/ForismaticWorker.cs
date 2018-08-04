using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MP.Forismatic
{
    internal class ForismaticWorker
    {
        private ForismaticModel model;

        private async void GetQuote()
        {
            using (var httpClient = new HttpClient())
            {
                var str = await httpClient.GetStringAsync("https://api.forismatic.com/api/1.0/?method=getQuote&key=457653&format=json&lang=en");
                model = JsonConvert.DeserializeObject<ForismaticModel>(str);
                lblQuote.Content = model.QuoteText;
                lblAuthor.Content = model.QuoteAuthor;
            }
        }
    }
}