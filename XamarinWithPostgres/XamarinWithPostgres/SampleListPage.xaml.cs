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

        private void LstData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem myItem = (ListItem)e.Item;
            DisplayAlert("Keterangan", $"Anda memilih item dengan judul {myItem.Title}", "OK");
        }
    }
}