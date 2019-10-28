using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Github.DataLayer.NewsModels.Develops;
using uri = Android.Net.Uri;
namespace Github.Android.Adapters
{
   
    public class ListVieTopDevsListViewAdapterAdapter : BaseAdapter
    {
        private Activity activity;
        private List<Developer> devs;
        Context context;
        static int pos = 0;
        public ListVieTopDevsListViewAdapterAdapter(Context context)
        {
            this.context = context;
        }
        public ListVieTopDevsListViewAdapterAdapter(Activity activity, List<Developer>devs)
        {
            this.activity = activity;
            this.devs = devs;
            
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
            var view = convertView ?? activity.LayoutInflater.Inflate(Resource.Layout.top_devs_listview_item, parent, false);
            var k = uri.Parse(devs[position].Avatar);



            view.FindViewById<TextView>(Resource.Id.position).Text = (pos++).ToString();
            view.FindViewById<ImageView>(Resource.Id.dev_avatar).SetImageBitmap(GetImageBitmapFromUrl(devs[position].Avatar));
            view.FindViewById<TextView>(Resource.Id.dev_username).Text = devs[position].Username;
            return view;
        }

        private Bitmap GetImageBitmapFromUrl(string url)
        {
            Bitmap imageBitmap = null;

            using (var webClient = new WebClient())
            {
                var imageBytes = webClient.DownloadData(url);
                if (imageBytes != null && imageBytes.Length > 0)
                {
                    imageBitmap = BitmapFactory.DecodeByteArray(imageBytes, 0, imageBytes.Length);
                }
            }

            return imageBitmap;
        }
        public override int Count
        {
            get
            {
                return devs.Count;
            }
        }

    }

    class ListViewAdapterViewHolder : Java.Lang.Object
    {
        public TextView Position { get; set; }
        public ImageView Avatar { get; set; }
        public TextView Username { get; set; }
    }
}