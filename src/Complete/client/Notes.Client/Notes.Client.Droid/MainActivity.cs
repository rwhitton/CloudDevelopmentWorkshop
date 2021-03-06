﻿using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Microsoft.Azure.Mobile;
using Notes.Client.Droid.Services;

namespace Notes.Client.Droid
{
    [Activity(Label = "Notes.Client", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            AzureService.Context = this;

            global::Xamarin.Forms.Forms.Init(this, bundle);
            MobileCenter.Configure("32c0d333-6b9c-4866-9159-0cc7d078971a");
            LoadApplication(new App());
        }
    }
}



