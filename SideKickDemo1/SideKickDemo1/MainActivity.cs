using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace SideKickDemo1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView TimeTextView;
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
        }

        private void TurnBackTimeButton_Click(object sender, System.EventArgs e)
        {
            TimeTextView.Text = "It's adventure time now!";
        }
    }
}