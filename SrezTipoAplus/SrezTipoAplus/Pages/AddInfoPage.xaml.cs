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
    public partial class AddInfoPage : ContentPage
    {
        public AddInfoPage(string itemName)
        {
            InitializeComponent();
            Title = itemName;
        }

        private async void btn_save_Clicked(object sender, EventArgs e)
        {
            var item = (Item)BindingContext;
            if (!String.IsNullOrEmpty(item.Name))
            {
                App.ItemDb.SaveItem(item);
            }
            await this.Navigation.PopAsync();
        }

        private void DatePicker_DateSelected(object sender, DateChangedEventArgs e)
        {

        }

        private async void deleteBtn_Clicked(object sender, EventArgs e)
        {
            var item = (Item)BindingContext;
            if (!String.IsNullOrEmpty(item.Name))
            {
                App.ItemDb.DeleteItem(item.ID);
            }
            await this.Navigation.PopAsync();
        }
    }
}