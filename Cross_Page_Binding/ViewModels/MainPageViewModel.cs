using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Cross_Page_Binding.ViewModels
{
    public class MainPageViewModel : BindableObject
    {
        private DateTime _boundDate = App.GlobalDate;
        private string _thisPagesText = App.GlobalText;
        public string ThisPagesText
        {
            get => _thisPagesText;
            set
            {
                _thisPagesText = value;
                App.GlobalText = value;
                OnPropertyChanged();
            }
        }
        public DateTime BoundDate
        {
            get => _boundDate;
            set
            {
                _boundDate = value;
                App.GlobalDate = value;
                OnPropertyChanged();

            }
        }
    }
}
