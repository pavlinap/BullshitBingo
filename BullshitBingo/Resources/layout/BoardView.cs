
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Graphics.Drawables;
using Android.Graphics;
using Android.Graphics.Drawables.Shapes;

namespace BullshitBingo
{
	public class BoardView : View
	{
		//private ShapeDrawable shape;

		public BoardView (Context context) : base (context)
		{
			Initialize ();
		}

		public BoardView (Context context, IAttributeSet attrs) : base (context, attrs)
		{
			Initialize ();
		}

		public BoardView (Context context, IAttributeSet attrs, int defStyle) :	base (context, attrs, defStyle)
		{
			Initialize ();
		}

		void Initialize ()
		{
			
		}

		protected override void OnDraw (Canvas canvas)
		{
			var paint = new Paint();
			paint.SetARGB(255, 200, 255, 0);
			paint.SetStyle(Paint.Style.Stroke);
			paint.StrokeWidth = 4;

			canvas.DrawCircle (200, 200, 180, paint);
		}
	}
}