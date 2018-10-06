using MP.ForismaticQuotes.Model;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace MP.ForismaticQuotes
{
    public class ForismaticWorker : IDisposable
    {
        private readonly string forismaticLink = "https://api.forismatic.com/api/1.0/?method=getQuote&format=json&lang=en";

        public async Task<string[]> GetQuoteAsync()
        {
            var output = new string[2];
            await Task.Run(async () =>
            {
                using (var httpClient = new HttpClient())
                {
                    QuoteModel quote;
                    var str = await httpClient.GetStringAsync(forismaticLink).ConfigureAwait(false);
                    quote = JsonConvert.DeserializeObject<QuoteModel>(str);
                    output[0] = quote.QuoteText;
                    output[1] = quote.QuoteAuthor;
                }
            }).ConfigureAwait(false);

            return output;
        }

        #region IDisposable Support

        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        // ~ForismaticWorker() {
        //   // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
        //   Dispose(false);
        // }

        // This code added to correctly implement the disposable pattern.
        void IDisposable.Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        #endregion IDisposable Support
    }
}