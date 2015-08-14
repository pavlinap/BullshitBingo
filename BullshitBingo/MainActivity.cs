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

namespace BullshitBingo
{
	[Activity (Label = "Bullshit Bingo", MainLauncher = true, Icon = "@drawable/icon")]
	public class MainActivity : Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			SetContentView (Resource.Layout.Main);

			Button btn_play = FindViewById<Button> (Resource.Id.btn_play);
			btn_play.Click += Play;

			Button btn_about = FindViewById<Button> (Resource.Id.btn_about);
			btn_about.Click += About;
		}

		void About (object sender, EventArgs e)
		{
			StartActivity (typeof(AboutActivity));
		}

		void Play (object sender, EventArgs e)
		{
			StartActivity (typeof(GameActivity));
		}
	}
}