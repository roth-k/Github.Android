﻿using System;
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
using V4Fragment = Android.Support.V4.App.Fragment;

namespace Github.Android.Fragments
{
    public class NewsFragment : V4Fragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
         
            return inflater.Inflate(Resource.Layout.news_layout_fragment, container, false);
        }
        public override void OnStop()
        {
            base.OnStop();
        }
    }
}