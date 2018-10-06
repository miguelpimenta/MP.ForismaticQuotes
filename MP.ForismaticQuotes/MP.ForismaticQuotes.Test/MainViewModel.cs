using System.Windows.Input;

namespace MP.ForismaticQuotes.Test
{
    public class MainViewModel : BindableBase
    {
        public ICommand GetQuoteCmd { get; }

        public MainViewModel()
        {
            GetQuoteCmd = new RelayCommand(GetQuoteAsync);
        }

        public string QuoteText { get; set; } = string.Empty;
        public string QuoteAuthor { get; set; } = string.Empty;

        private async void GetQuoteAsync(object obj)
        {
            using (ForismaticWorker worker = new ForismaticQuotes.ForismaticWorker())
            {
                var output = await worker.GetQuoteAsync().ConfigureAwait(false);
                QuoteText = output[0];
                QuoteAuthor = output[1];
                RaisePropertyChanged(null);
            }
        }
    }
}