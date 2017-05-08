using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace iPortaliAndroid
{
    [Activity(Label = "iPortaliAndroid", Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button btnPianoTerra = FindViewById<Button>(Resource.Id.btnPianoTerra);
            Button btnPrimoPiano = FindViewById<Button>(Resource.Id.btnPrimoPiano);
            Button btnLatoOvest = FindViewById<Button>(Resource.Id.btnLatoOvest);
            Button btnFindStore = FindViewById<Button>(Resource.Id.btnFindStore);


            btnPianoTerra.Click += delegate {
                var intent = new Intent(this, typeof(ActivityPianoTerra));
                StartActivity(intent);
            };

            btnPrimoPiano.Click += delegate
            {
                var intent = new Intent(this, typeof(ActivityPrimoPiano));
                StartActivity(intent);
            };

            btnLatoOvest.Click += delegate
            {
                var intent = new Intent(this, typeof(ActivityLatoOvest));
                StartActivity(intent);
            };

            btnFindStore.Click += delegate
            {
                var intent = new Intent(this, typeof(ActivityFindStore));
                StartActivity(intent);
            };
        }
    }
}

