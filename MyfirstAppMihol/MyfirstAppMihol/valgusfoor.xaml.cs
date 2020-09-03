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
    public partial class valgusfoor : ContentPage
    {
        public valgusfoor()
        {
            InitializeComponent();
        }
        Random rnd = new Random();
        int redik = 0;
    }
}