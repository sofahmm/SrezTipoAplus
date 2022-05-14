using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SrezTipoAplus.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisttrationPage : ContentPage
    {
        public RegisttrationPage()
        {
            InitializeComponent();
        }

        private async void RegistrBtn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}