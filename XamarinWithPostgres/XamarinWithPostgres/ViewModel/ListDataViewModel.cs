using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace XamarinWithPostgres.ViewModel
{
    public class ListDataViewModel : BindableObject
    {
        public ListDataViewModel()
        {
            listItems = new List<ListItem> {
                new ListItem
                {
                    Title = "Sate Klathak Pak Jeje",
                    Description = "Sate Klathak Pak Jeje Pasar Jejeran"
                },
                new ListItem {
                    Title = "Soto Kadipiro",
                    Description="Soto Kadipiro jalan Wates"
                },
                new ListItem{
                    Title="Bakmi Jawa Mbah Hadi",
                    Description="Bakmi Jawa Mbah Hadi terban"
                }
            };
        }

        private List<ListItem> listItems;
        public List<ListItem> ListItems
        {
            get { return listItems; }
            set { listItems = value; OnPropertyChanged("ListItems"); }
        }

    }
}
