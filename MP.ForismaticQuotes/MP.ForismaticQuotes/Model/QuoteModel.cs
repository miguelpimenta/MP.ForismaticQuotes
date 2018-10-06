using MP.Forismatic;
using System.ComponentModel;

namespace MP.ForismaticQuotes.Model
{
    [Notify]
    public class QuoteModel : INotifyPropertyChanged
    {
        public string QuoteText { get { return quoteText; } set { SetProperty(ref quoteText, value, quoteTextPropertyChangedEventArgs); } }
        public string QuoteAuthor { get { return quoteAuthor; } set { SetProperty(ref quoteAuthor, value, quoteAuthorPropertyChangedEventArgs); } }
        public string SenderName { get { return senderName; } set { SetProperty(ref senderName, value, senderNamePropertyChangedEventArgs); } }
        public string SenderLink { get { return senderLink; } set { SetProperty(ref senderLink, value, senderLinkPropertyChangedEventArgs); } }
        public string QuoteLink { get { return quoteLink; } set { SetProperty(ref quoteLink, value, quoteLinkPropertyChangedEventArgs); } }

        public QuoteModel()
        {
        }

        #region NotifyPropertyChangedGenerator

        public event PropertyChangedEventHandler PropertyChanged;

        private string quoteText;
        private static readonly PropertyChangedEventArgs quoteTextPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(QuoteText));
        private string quoteAuthor;
        private static readonly PropertyChangedEventArgs quoteAuthorPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(QuoteAuthor));
        private string senderName;
        private static readonly PropertyChangedEventArgs senderNamePropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(SenderName));
        private string senderLink;
        private static readonly PropertyChangedEventArgs senderLinkPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(SenderLink));
        private string quoteLink;
        private static readonly PropertyChangedEventArgs quoteLinkPropertyChangedEventArgs = new PropertyChangedEventArgs(nameof(QuoteLink));

        private void SetProperty<T>(ref T field, T value, PropertyChangedEventArgs ev)
        {
            if (!System.Collections.Generic.EqualityComparer<T>.Default.Equals(field, value))
            {
                field = value;
                PropertyChanged?.Invoke(this, ev);
            }
        }

        #endregion NotifyPropertyChangedGenerator
    }
}