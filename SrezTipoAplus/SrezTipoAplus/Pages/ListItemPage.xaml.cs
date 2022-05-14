using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SrezTipoAplus.Model;
using SrezTipoAplus.Data;

namespace SrezTipoAplus.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListItemPage : ContentPage
    {
        public string[] items { get; set; }
        public ListItemPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            itemsLv.ItemsSource = App.ItemDb.GetItem();
            base.OnAppearing();
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddInfoPage(null));
        }

        private async void itemsLv_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new AddInfoPage(itemsLv.SelectedItem.ToString()));
        }
    }
}