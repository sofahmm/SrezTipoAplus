using SrezTipoAplus.Data;
using System;
using System.Collections;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrezTipoAplus
{
    public partial class App : Application
    {
        static ItemDb itemDb;
        public static ItemDb ItemDb
        {
            get
            {
                if (itemDb == null)
                {
                    itemDb = new ItemDb(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "ItemsDatabase.db3"));
                }
                return itemDb;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Pages.AuthorizationPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
