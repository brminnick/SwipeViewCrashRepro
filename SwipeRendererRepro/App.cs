using Xamarin.Forms;

namespace SwipeRendererRepro
{
    public class App : Application
    {
        public App()
        {
            Device.SetFlags(new[] { "SwipeView_Experimental" });
            MainPage = new MainPage();
        }
    }

    class MainPage : ContentPage
    {
        public MainPage()
        {
            var label = new Label
            {
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Text = "Swipe Right-to-Left to Crash App\n\nSwipe Left-to-Right for Working Example",
                BackgroundColor = Color.LightGoldenrodYellow
            };

            var swipeItemWithText = new SwipeItem
            {
                IconImageSource = "AppIcon",
                BackgroundColor = Color.Green,
                Text = "Test"
            };

            var swipeItemWithNoText = new SwipeItem
            {
                IconImageSource = "AppIcon",
                BackgroundColor = Color.Red
            };

            var swipeView = new SwipeView
            {
                Margin = new Thickness(20),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand,
                LeftItems = { swipeItemWithText },
                RightItems = { swipeItemWithNoText },
                Content = label
            };
            
            Content = swipeView;
        }
    }
}
