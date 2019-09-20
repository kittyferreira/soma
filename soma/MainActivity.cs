using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;

namespace soma
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            Button btn = FindViewById<Button>(Resource.Id.btncal);
            EditText n1 = FindViewById<EditText>(Resource.Id.textn1);
            EditText n2 = FindViewById<EditText>(Resource.Id.textn2);
            EditText rst = FindViewById<EditText>(Resource.Id.textrst);

            btn.Click += delegate
            {
                float nun1 = float.Parse(n1.Text);
                float nun2 = float.Parse(n2.Text);
                float resul = nun1 + nun2;
                rst.Text = Convert.ToString(resul);

            };

                
                
        }
    }
}