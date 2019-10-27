using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Github.Android.Fragments;
using FragTrans = Android.Support.V4.App.FragmentTransaction;
using Frag = Android.Support.V4.App.Fragment;
using Github.DataLayer.NewsModels.Develops;
using System.Collections.Generic;
using Github.Services.Implementations;
using Github.Repository;
using Github.Android.Adapters;

namespace Github.Android
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity, BottomNavigationView.IOnNavigationItemSelectedListener
    {
       
        NewsFragment news = new NewsFragment();
        TopDevsFragment devs = new TopDevsFragment();
        TopReposFragment repo = new TopReposFragment();
        
        Frag frag;
        FragTrans trans;
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

           
            BottomNavigationView navigation = FindViewById<BottomNavigationView>(Resource.Id.navigation);
            navigation.SetOnNavigationItemSelectedListener(this);
           
        }
       
        public bool OnNavigationItemSelected(IMenuItem item)
        {
            trans = SupportFragmentManager.BeginTransaction();
            
           
            if (frag != null)
                trans.Remove(frag);
            switch (item.ItemId)
            {
                case Resource.Id.navigation_home:
                    frag = news;
                    break;
                 case Resource.Id.navigation_dashboard:
                    frag = devs;
                    break;
                 case Resource.Id.navigation_notifications:
                    frag = repo;
                    break;
            }
            trans.Add(Resource.Id.frameLayout, frag).Commit();
            return false;
        }
    }
}

