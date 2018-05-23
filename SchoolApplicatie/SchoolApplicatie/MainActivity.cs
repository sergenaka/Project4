using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using System.Timers;
using System;

namespace SchoolApplicatie
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        private Button stopknop;
        private TextView txtCountdown;
        private int count = 1;
        Timer timer;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            stopknop = FindViewById <Button> (Resource.Id.stopknop);
            txtCountdown = FindViewById <TextView> (Resource.Id.txtCountdown);
            stopknop.Click += stopknop_Click;           
        }

        private void stopknop_Click(object sender, EventArgs e)
        {
            txtCountdown.Text = "Stop";
            timer.Stop();
        }

        protected override void OnResume()
        {
            base.OnResume();
            timer = new Timer();
            timer.Interval = 1000; // 1 sec
            timer.Elapsed += Timer_Elapsed;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            if (count < 10)
            {
                count++;
                RunOnUiThread(() =>
               {
                   txtCountdown.Text = "" + count;
               });
            }
            else
            {
                count = 1;
                Toast.MakeText(this, "Hello", ToastLength.Short).Show();
                txtCountdown.Text = "" + count;
            }
        }
    }

}

