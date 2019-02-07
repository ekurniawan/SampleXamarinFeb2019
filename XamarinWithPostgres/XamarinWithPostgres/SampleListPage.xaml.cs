using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinWithPostgres.ViewModel;

namespace XamarinWithPostgres
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListPage : ContentPage
    {
        public SampleListPage()
        {
            InitializeComponent();
            BindingContext = new ListDataViewModel();
        }
    }
}