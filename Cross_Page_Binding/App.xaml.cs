using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cross_Page_Binding
{
    public partial class App : Application
    {
        public static string GlobalText { get; set; } = "This is the Global";
        public static DateTime GlobalDate { get; set; } = DateTime.Now;

        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
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
