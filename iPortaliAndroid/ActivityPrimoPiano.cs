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
using Android.Webkit;

namespace iPortaliAndroid
{
    [Activity(Label = "ActivityPrimoPiano")]
    public class ActivityPrimoPiano : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.frmPrimoPiano);
            // Create your application here

            WebView view = FindViewById<WebView>(Resource.Id.webView1);

            if (view != null)
            {
                String imageUrl = "file:///android_asset/primo_piano.png";
                view.Settings.DefaultZoom = WebSettings.ZoomDensity.Far;
                view.Settings.SetSupportZoom(true);
                view.Settings.BuiltInZoomControls = true;
                view.LoadUrl(imageUrl);
            }
        }
    }
}