using Android.App;
using Android.Widget;
using Android.OS;
using System;

namespace Testingapp.Droid
{
	[Activity(Label = "Testing app", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		int count = 1;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);

			// Set our view from the "main" layout resource
			SetContentView(Resource.Layout.Main);

			// Get our button from the layout resource,
			// and attach an event to it
			Button button = FindViewById<Button>(Resource.Id.myButton);
			TextView textView = FindViewById<TextView>(Resource.Id.textView1);
			Button changeTextButton = FindViewById<Button>(Resource.Id.button1);
			EditText textField = FindViewById<EditText>(Resource.Id.editText);
			Button clearTextButton = FindViewById<Button>(Resource.Id.clearTextButton);


			button.Click += delegate {

				StartActivity(typeof(LayoutActivity));
				Console.WriteLine("We did it!");

				 };

			changeTextButton.Click += delegate {


					textView.Text = string.Format("{0}", textField.EditableText);
					Console.WriteLine("Text has been set");

				textView.SetTextColor(Android.Graphics.Color.Red);

			};

			textField.TextChanged += delegate {

				Console.WriteLine(textField.EditableText);
				textView.Text = string.Format("{0}", textField.EditableText);


			};

			clearTextButton.Click += delegate {

				textView.Text = "";
				textField.Text = "";

				Console.WriteLine("The text has been cleared");

			};
		}
	}
}

