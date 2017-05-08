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
using Android.Media;
using System.IO;
using static Android.Widget.AdapterView;

namespace iPortaliAndroid
{
    [Activity(Label = "ActivityFindStore")]
    public class ActivityFindStore : Activity
    {
        AutoCompleteTextView autocompleteTextView;
        List<string> Groups = new List<string>();
        List<string> Names = new List<string>();
        List<string> Position = new List<string>();

        protected int getItemPos(string searchField)
        {
            foreach(string v in Names)
            {
                int i = 0;
                if (v == Names[i])
                    return i;
                i++;
            }
            return -1;
        }


        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            // event code here
            string selection = autocompleteTextView.Text;

            int pos = getItemPos(selection);

            string Category = Groups[pos];
            string Pos = Position[pos];

        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.frmFindStore);
            // Create your application here
            autocompleteTextView = FindViewById<AutoCompleteTextView>(Resource.Id.autoCompleteTextView1);

            autocompleteTextView.ItemClick += lv_ItemClick;


            // instead of the small array of greetings, use a large dictionary of words loaded from a file
            System.IO.Stream seedDataStream = Assets.Open("poi.txt");


            using (StreamReader reader = new StreamReader(seedDataStream))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string temp = line;
                    string[] temp2 = temp.Split('\t');
                    if (temp2.Length >= 2)
                    {
                        Groups.Add(temp2[0]);
                        Names.Add(temp2[1]);
                        Position.Add(temp2[2]);
                    }
                }
            }
            string[] wordlist = Names.ToArray();
            ArrayAdapter dictionaryAdapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleDropDownItem1Line, wordlist);
            autocompleteTextView.Adapter = dictionaryAdapter;

        }
    }
}