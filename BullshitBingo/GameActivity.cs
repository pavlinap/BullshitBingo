using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace BullshitBingo
{
	[Activity (Label = "Bullshit Bingo", ParentActivity = typeof(MainActivity), Icon = "@drawable/icon")]
	public class GameActivity : Activity
	{
		private GridAdapter adapter;

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			ActionBar.SetDisplayHomeAsUpEnabled (true);

			if (DataHolder.Current == null)
				new DataHolder ();

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Game);

			adapter = new GridAdapter (this, -1, DataHolder.Current.phrases);

			var gridView = FindViewById<GridView> (Resource.Id.gridView1);
			gridView.Adapter = adapter;
			gridView.ItemClick += BingoItemClicked;
		}

		private void BingoItemClicked (object sender, AdapterView.ItemClickEventArgs e)
		{
			DataHolder.Current.phrases [e.Position].Set = !DataHolder.Current.phrases [e.Position].Set;
			adapter.NotifyDataSetChanged ();
			CheckIfGameWon ();
		}

		private void CheckIfGameWon ()
		{
			//check vertical win
			for (int i = 0; i < 5; i++) {
				if (DataHolder.Current.phrases [i].Set == true && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 5].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 10].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 15].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 20].Set)
					CongratulateWinner ();
			}

			//check horizontal win
			for (int i = 0; i < DataHolder.Current.phrases.Count; i += 5) {
				if (DataHolder.Current.phrases [i].Set == true && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 1].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 2].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 3].Set && DataHolder.Current.phrases [i].Set == DataHolder.Current.phrases [i + 4].Set)
					CongratulateWinner ();
			}
		}

		private void CongratulateWinner ()
		{
			AlertDialog.Builder alert = new AlertDialog.Builder (this)
				.SetTitle ("You won, congratulations!")
				.SetPositiveButton ("Thanks", (senderAlert, args) => {
				// what to do when the button is clicked? 
				Finish ();
				DataHolder.Current = null;
			});

			//run the alert in UI thread to display in the screen
			RunOnUiThread (() => {
				alert.Show ();
			});
		
		}
	}
}