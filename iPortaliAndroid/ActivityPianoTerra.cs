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
    [Activity(Label = "ActivityPianoTerra")]
    public class ActivityPianoTerra : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.frmPianoTerra);

            WebView view = FindViewById<WebView>(Resource.Id.webView1);

            if (view != null)
            {
                String imageUrl = "file:///android_asset/piano_terra.png";
                view.Settings.DefaultZoom = WebSettings.ZoomDensity.Far;
                view.Settings.SetSupportZoom(true);
                view.Settings.BuiltInZoomControls = true;
                view.LoadUrl(imageUrl);
            }
        }
    }
}