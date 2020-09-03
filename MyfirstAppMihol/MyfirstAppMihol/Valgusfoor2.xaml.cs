using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace MyfirstAppMihol
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Valgusfoor2 : ContentPage
    {
        public Valgusfoor2()
        {
            //InitializeComponent();
            Label punane = new Label()
            {
                Text = "Punan",
                TextColor = Color.Red,
                FontSize=30,
                FontAttributes=FontAttributes.Bold
            };
            Frame pun = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = punane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label kollane = new Label()
            {
                Text = "Kollane",
                TextColor = Color.Yellow,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame kol = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = kollane,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            Label roheline = new Label()
            {
                Text = "Roheline",
                TextColor = Color.Green,
                FontSize = 30,
                FontAttributes = FontAttributes.Bold
            };
            Frame roh = new Frame()
            {
                BackgroundColor = Color.Red,
                Content = roheline,
                CornerRadius = 90,
                Margin = new Thickness(80, 0, 80, 0)
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { pun, kol, roh }
            };
            //stackLayout.Orientation = StackOrientation.Horizontal;
            Content = stackLayout;
            StackLayout stackLayout1 = new StackLayout()
            {

            };
        }
    }
}