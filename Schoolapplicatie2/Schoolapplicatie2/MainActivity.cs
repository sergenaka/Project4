using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;

namespace Schoolapplicatie2
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
        private static long START_TIME_IN_MILLIS = 600000;
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
        }
    }
}

