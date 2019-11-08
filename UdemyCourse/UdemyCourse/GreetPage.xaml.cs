
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UdemyCourse
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreetPage : ContentPage
    {
        public GreetPage()
        {
            InitializeComponent();

            slider.Value = 0.5; // after InitializeComponent();

            // It's possible to create UI here instead of XAML
            //Content = new Label
            //{
            //    HorizontalOptions = LayoutOptions.Center,
            //    VerticalOptions = LayoutOptions.Center,
            //    Text = "Hello World"
            //};


            // Specific code for iOS or Android
            //switch(Device.RuntimePlatform)
            //{
            //    case Device.iOS:
            //        Padding = new Thickness(0, 20, 0, 0);
            //    break;
            //    case Device.Android:
            //        Padding = new Thickness(0, 50, 0, 0);
            //    break;
            //}
        }

        //event handler, not neccessary if using data binding
        //private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        //{
        //    label.Text = string.Format("Value is {0:F2}", e.NewValue);
        //}
    }
}