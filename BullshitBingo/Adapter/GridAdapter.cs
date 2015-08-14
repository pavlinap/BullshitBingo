using System;
using Android.Widget;
using System.Collections.Generic;
using Android.Content;
using Android.Views;

namespace BullshitBingo
{
	public class GridAdapter: ArrayAdapter<Phrase>
	{
		public GridAdapter (Context context, int resourceId, List<Phrase> items) : base(context, resourceId, items)
		{
			
		}

		public override Android.Views.View GetView (int position, Android.Views.View convertView, Android.Views.ViewGroup parent)
		{
			
			var view = convertView;
			if (view == null)
				view = LayoutInflater.From(Context).Inflate (Resource.Layout.BingoItem, null);

			view.FindViewById<TextView> (Resource.Id.tv_bingoItem).Text = GetItem (position).Name;
			if (GetItem (position).Set)
				view.FindViewById<ImageView> (Resource.Id.iv_marker).Visibility = ViewStates.Visible;
			else
				view.FindViewById<ImageView> (Resource.Id.iv_marker).Visibility = ViewStates.Invisible;
			
			return view;
		}
	}
}