using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidLab1
{
    [Activity(Label = "AndroidLab1", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button button = FindViewById<Button>(Resource.Id.btn_echo);
            TextView tv = FindViewById<TextView>(Resource.Id.tv_Echo);
            EditText ed = FindViewById<EditText>(Resource.Id.et_input);

            button.Click += delegate { tv.Text = ed.Text; };
        }
    }
}

