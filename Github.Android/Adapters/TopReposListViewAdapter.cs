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
using Github.DataLayer.NewsModels.Repos;

namespace Github.Android.Adapters
{
    class TopReposListViewAdapter : BaseAdapter
    {

        Context context;
        Activity activity;
        List<Reposit> list;
        public TopReposListViewAdapter(Context context)
        {
            this.context = context;
        }
        public TopReposListViewAdapter(Activity activity,List<Reposit>list)
        {
            this.activity = activity;
            this.list = list;
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view =convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.top_repos_listview_item, parent, false);
            view.FindViewById<TextView>(Resource.Id.position).Text = "0";
            view.FindViewById<TextView>(Resource.Id.name).Text = list[position].Name;
            return view;
        }

        //Fill in cound here, currently 0
        public override int Count
        {
            get
            {
                return list.Count;
            }
        }

    }

    class TopReposListViewAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        //public TextView Title { get; set; }
    }
}