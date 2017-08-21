using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AquaSmart
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public  FirstPage()
        {
            
            InitializeComponent();
            BackgroundColor = Color.White;
            Appear();
            switch (Device.RuntimePlatform)
            {
                case Device.iOS:
                    platform_image.Source = ImageSource.FromFile("Icon-76@2x.png");
                    neo_image.Source = ImageSource.FromFile("neo.jpg");
                    break;
                case Device.Android:
                    platform_image.Source = ImageSource.FromFile("aqua1.jpg");
                    neo_image.Source = ImageSource.FromFile("neo.jpg");
                    break;
                case Device.WinPhone:
                    platform_image.Source = ImageSource.FromFile("aqua1.jpg");
                    neo_image.Source = ImageSource.FromFile("neo.jpg");
                    break;
            }
            
        }
        public async void Appear()
        {
            int i = 1;
            while(i==1)
            {
                Act.IsRunning = true;
                Act.IsVisible = true;
                Act.IsEnabled = true;
                await Task.Delay(4000);
                i = 0;
            }


            //Navigation.PushModalAsync(new Device_Registration());
            
            platform_image.Opacity = 1.0;
            Aqua.Opacity = 1.0;
            neo_image.Opacity = 1.0;
            Act.Opacity = 0.0;
            Power.Opacity = 1.0;
            Neotech.Opacity = 1.0;
        }
    }
}


