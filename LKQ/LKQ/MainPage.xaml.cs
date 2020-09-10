using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LKQ.ViewModels;
namespace LKQ
{

    public partial class MainPage : ContentPage
    {
        public MainPageViewModel viewModel = new MainPageViewModel();
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
            cv.ItemsSource = viewModel.ButtonList;
        }
        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var button = (Button)sender;
            button.BackgroundColor = Color.FromHex("#CBCEEC");
            var name = button.Text;
            var binddata = new MainPageViewModel(name);

            cv.ItemsSource = binddata.ButtonList;
            switch (name)
            {
                case "Sales":

                    sales.BackgroundColor = Color.White;
                    break;
                case "Trn":
                    trn.BackgroundColor = Color.White;

                    break;
                case "Proc":
                    proc.BackgroundColor = Color.White;

                    break;
                case "Inq":
                    inq.BackgroundColor = Color.White;

                    break;
                case "Lbls":
                    lbls.BackgroundColor = Color.White;

                    break;
            }


        }
    }
}
