using Android.App;
using Android.OS;
using BottomNavigationBar;
using Android.Views;
using System;
using Android.Support.V7.App;
using Android.Widget;

namespace BottomBarSample.Activities
{
    [Activity(Label = "Bottom Bar Sample", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, View.IOnClickListener
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Main);
            FindViewById(Resource.Id.simple_three_tabs).SetOnClickListener(this);
			FindViewById(Resource.Id.icons_only).SetOnClickListener(this);
			FindViewById(Resource.Id.five_tabs_changing_colors).SetOnClickListener(this);
			FindViewById(Resource.Id.three_tabs_quick_return).SetOnClickListener(this);
			FindViewById(Resource.Id.five_tabs_custom_colors).SetOnClickListener(this);
			FindViewById(Resource.Id.badges).SetOnClickListener(this);

            BottomBar bar = new BottomBar();
        }
		public void OnClick(View v)
		{
            Type newActivity = null;

            switch (v.Id)
            {
                case Resource.Id.simple_three_tabs: newActivity = typeof(ThreeTabsActivity); ShowMessage(); break;
                case Resource.Id.icons_only: newActivity = typeof(IconsOnlyActivity); ShowMessage(); break;
                case Resource.Id.five_tabs_changing_colors: newActivity = typeof(FiveColorChangingTabsActivity); ShowMessage(); break;
                case Resource.Id.three_tabs_quick_return: newActivity = typeof(ThreeTabsQRActivity); ShowMessage(); break;
                case Resource.Id.five_tabs_custom_colors: newActivity = typeof(CustomColorAndFontActivity); ShowMessage(); break;
                case Resource.Id.badges: newActivity = typeof(BadgeActivity); ShowMessage(); break;
            }

            StartActivity(newActivity);
		}
        private void ShowMessage()
        {
            Toast.MakeText(this,"Not implemented!", ToastLength.Long).Show();
        }

    }
}

