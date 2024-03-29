﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Tabloide.Configurations;
using Tabloide.Droid.Platform.Display;
using Xamarin.FileStorage.Android;

namespace Tabloide.Droid
{
	[Activity(Label = "Tabloide", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			AppConfig.SetUp(new FileStorage(), new DisplayMetrics());

			TabLayoutResource = Resource.Layout.Tabbar;
			ToolbarResource = Resource.Layout.Toolbar;

			base.OnCreate(bundle);

			global::Xamarin.Forms.Forms.Init(this, bundle);
			XamEffects.Droid.Effects.Init();

			LoadApplication(new App());
		}
	}
}
