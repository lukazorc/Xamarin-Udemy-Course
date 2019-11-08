
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuotesPage : ContentPage
    {
        private int _index = 0;
        string[] _quotes = { "Quote 1", "Quote 2", "Quote 3", "Quote 4", "Quote 5", "Quote 6" };

        public QuotesPage()
        {
            InitializeComponent();


            currentQuote.Text = _quotes[_index];
        }

        private void Button_Clicked(object sender, System.EventArgs e)
        {
            _index++;
            if (_index == _quotes.Length)
            {
                _index = 0;
            }

            currentQuote.Text = _quotes[_index];

        }
    }
}