
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Threading;

namespace Testingapp.Droid
{
	[Activity(Label = "LayoutActivity")]
	public class LayoutActivity : Activity
	{
		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			SetContentView(Resource.Layout.LayoutActivity);

			Button button = FindViewById<Button>(Resource.Id.button1);
			TextView textView = FindViewById<TextView>(Resource.Id.textView1);

			textView.Gravity = GravityFlags.Center;
			textView.SetTextColor(Android.Graphics.Color.ParseColor("#FF11FF"));

			button.Click += delegate {

				StartActivity(typeof(MainActivity));
				Console.WriteLine("Going back");

			};

			int count = 0;

			while (true)
			{

				string countString = count.ToString();
				textView.Text = countString;
				count++;
				Thread.Sleep(99999);

			}






		}
	}
}
