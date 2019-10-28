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
using Github.Android.Adapters;
using Github.DataLayer.NewsModels.Repos;
using Github.Services.Implementations;
using V4Fragment = Android.Support.V4.App.Fragment;

namespace Github.Android.Fragments
{
    public class TopReposFragment : V4Fragment
    {
        View view;
        public async override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            var list = await new GetTopReposService().GetRepos("C#", Repository.TimePeriod.daily);
            var listview = view?.FindViewById<ListView>(Resource.Id.repo_list);
            var adapter = new TopReposListViewAdapter(this.Activity, list);
            listview.Adapter = adapter;
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
          view= inflater.Inflate(Resource.Layout.top_repos_fragment, container, false);
            return view;
        }
    }
}