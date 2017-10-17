using Android.App;
using Android.Widget;
using Android.OS;

namespace Bmi.android
{
    [Activity(Label = "Bmi.android", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            Xamarin.Insights.Initialize(XamarinInsights.ApiKey, this);
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
           
        }
    }
}

