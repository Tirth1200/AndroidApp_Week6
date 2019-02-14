using System;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;

namespace Arithmetic_Operations
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        TextView vnum1, vnum2, voperation, vresult;
        EditText tnum1,tnum2,tresult;
        Button bplus, bsub,bmul,bdiv;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);
            vnum1 = (TextView)FindViewById(Resource.Id.tvnum1);
            vnum2 = (TextView)FindViewById(Resource.Id.tvnum2);
            vresult = (TextView)FindViewById(Resource.Id.tvresult);
            tnum1 = (EditText)FindViewById(Resource.Id.etnum1);
            tnum2 = (EditText)FindViewById(Resource.Id.etnum2);
            tresult = (EditText)FindViewById(Resource.Id.etresult);
            bplus = (Button)FindViewById(Resource.Id.bnplus);
            bsub = (Button)FindViewById(Resource.Id.bnsub);
            bmul = (Button)FindViewById(Resource.Id.bnmul);
            bdiv = (Button)FindViewById(Resource.Id.bndiv);

            bplus.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a+b;
                tresult.Text = r.ToString();
            };
            bsub.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a - b;
                tresult.Text = r.ToString();
            };
            bmul.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a * b;
                tresult.Text = r.ToString();
            };
            bdiv.Click += delegate
            {
                double a = double.Parse(tnum1.Text);
                double b = double.Parse(tnum2.Text);
                double r = a / b;
                tresult.Text = r.ToString();
            };
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

