/*
 * BottomBar library for Xamarin Android
 * Copyright (c) 2017 Alírio Mendes (http://github.com/aliriomendes).
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
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

