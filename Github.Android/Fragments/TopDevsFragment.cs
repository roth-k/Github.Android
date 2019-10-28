using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Github.Android.Adapters;
using Github.DataLayer.NewsModels.Develops;
using Github.Repository;
using Github.Services.Implementations;
using V4Fragment = Android.Support.V4.App.Fragment;
namespace Github.Android.Fragments
{
    public class TopDevsFragment : V4Fragment
    {
        List<Developer> list;
        View view;
        public async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            
            list = await new GetTopDeveloersService().GetDevelopers("C#", TimePeriod.daily);
          

            var listview = view.FindViewById<ListView>(Resource.Id.devs_list);
            var adapter = new ListVieTopDevsListViewAdapterAdapter(this.Activity, list);

            listview.Adapter = adapter;
            
            // Create your fragment here
        }
       
        public  override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            view = inflater.Inflate(Resource.Layout.top_devs_fragment, null);
            return view;
        }
    }
}