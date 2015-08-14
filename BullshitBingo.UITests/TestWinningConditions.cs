using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace BullshitBingo.UITests
{
	[TestFixture]
	public class TestWinningConditions
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp.Android.StartApp ();
			app.Screenshot ("Given the app is loaded");
			app.Tap (x => x.Button ("btn_play"));

			app.WaitForElement (x => x.Id ("tv_bingoItem"));

			var results = app.Query (x => x.Id ("tv_bingoItem"));
			Assert.AreEqual (25, results.Length);
			app.Screenshot ("25 items should be shown");
		}

		[Test]
		public void VerticalPhrases ()
		{
			app.Tap (x => x.Class ("TextView").Index (1));
			app.Tap (x => x.Class ("TextView").Index (6));
			app.Tap (x => x.Class ("TextView").Index (11));
			app.Tap (x => x.Class ("TextView").Index (16));
			app.Screenshot ("4 in a column are selected");
			app.Tap (x => x.Class ("TextView").Index (21));

			app.WaitForElement (x => x.Id ("alertTitle"));

			var results = app.Query (x => x.Id ("alertTitle"));
			Assert.AreEqual ("You won, congratulations!", results [0].Text);
			app.Screenshot ("A Congratulating dialog should appear");
		}

		[Test]
		public void HorizontalPhrases ()
		{
			app.Tap (x => x.Class ("TextView").Index (0));
			app.Tap (x => x.Class ("TextView").Index (1));
			app.Tap (x => x.Class ("TextView").Index (2));
			app.Tap (x => x.Class ("TextView").Index (3));
			app.Screenshot ("4 in a row are selected");
			app.Tap (x => x.Class ("TextView").Index (4));

			app.WaitForElement (x => x.Id ("alertTitle"));

			var results = app.Query (x => x.Id ("alertTitle"));
			Assert.AreEqual ("You won, congratulations!", results [0].Text);
			app.Screenshot ("A Congratulating dialog should appear");
		}
	}
}