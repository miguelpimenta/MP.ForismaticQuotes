using System.ComponentModel;

namespace MP.Forismatic
{
    public class QuoteModel : INotifyPropertyChanged
    {
        private string _quoteText = string.Empty;

        public string QuoteText
        {
            get => _quoteText;
            set { _quoteText = value; RaisePropertyChanged(nameof(QuoteText)); }
        }

        public string QuoteAuthor { get; set; } = string.Empty;
        public string SenderName { get; set; } = string.Empty;
        public string SenderLink { get; set; } = string.Empty;
        public string QuoteLink { get; set; } = string.Empty;

        public QuoteModel()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, e);
        }
    }
}