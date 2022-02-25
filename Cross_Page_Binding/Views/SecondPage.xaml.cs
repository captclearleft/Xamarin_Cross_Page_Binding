using Cross_Page_Binding.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cross_Page_Binding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SecondPage : ContentPage
    {
        public SecondPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            //base.OnAppearing();
            //BindingContext = null;
            BindingContext = new MainPageViewModel();


        }
    }
}