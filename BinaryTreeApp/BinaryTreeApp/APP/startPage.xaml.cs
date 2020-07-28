using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BinaryTreeApp.APP
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class startPage : ContentPage
    {
        public startPage()
        {
            InitializeComponent();
        }

        public void main_app(object sender, EventArgs e)
        {
            Navigation.PushAsync(new mainPage());
        }
    }
}