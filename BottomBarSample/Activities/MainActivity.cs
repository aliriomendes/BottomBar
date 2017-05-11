using Android.App;
using Android.OS;

namespace BottomBarSample.Activities
{
    [Activity(Label = "Bottom Bar Sample", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
        }
    }
}

