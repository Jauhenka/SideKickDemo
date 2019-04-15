using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace SideKickDemo1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView TimeTextView;
        int secondsOffset = 0;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button turnBackTimeButton = FindViewById<Button>(Resource.Id.buttonTurnBackTime);
            ImageView exitImageView = FindViewById<ImageView>(Resource.Id.imageViewExit);
            Button menuButton = FindViewById<Button>(Resource.Id.buttonMenu);
            TimeTextView = FindViewById<TextView>(Resource.Id.textViewTime);

            turnBackTimeButton.Click += TurnBackTimeButton_Click;

            System.Timers.Timer updatingClockTimer = new System.Timers.Timer();
            updatingClockTimer.Interval = 1000;
            updatingClockTimer.Enabled = true;
            updatingClockTimer.Elapsed += (object sender, System.Timers.ElapsedEventArgs e) =>
            {
                TimeTextView.Text = "It is " + DateTime.Now.AddSeconds(secondsOffset).ToLongTimeString() + " now";
            };
            updatingClockTimer.Start();
        }

        private void TurnBackTimeButton_Click(object sender, System.EventArgs e)
        {
            secondsOffset -= 30;
        }
    }
}