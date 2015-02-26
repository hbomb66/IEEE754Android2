using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

//Don't try this at home

namespace IEEE754Convert
{


	[Activity (Label = "IEEE 754 Convert", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			//Button btn_clear = FindViewById<Button> (Resource.Id.btn_clear);

			Button btn_singleP = FindViewById<Button> (Resource.Id.btn_singleP);

			//Button btn_doubleP = FindViewById<Button> (Resource.Id.btn_doubleP);

			btn_singleP.Click += new EventHandler (btn_singlePClick);

		}

		void btn_singlePClick(object sender, EventArgs e) {

			EditText inputBox = FindViewById<EditText> (Resource.Id.txtbox_input);
			TextView outputBox = FindViewById<TextView> (Resource.Id.txtbox_output);
			String inputString = inputBox.Text;

			int inputInt = Convert.ToInt32 (inputString);

			int[] bits = decimal.GetBits (inputInt);

			string bitLines = string.Join (System.Environment.NewLine, bits);

			outputBox.Text = bitLines;

		}
	}
}


