using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationErik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Esmaspaev : ContentPage
    {
        public Esmaspaev()
        {
            string[] tasks = new string[] { "Встаю", "Завтракаю", "Иду в тех", "Учусь", "Ем", "Учусь", "Иду домой", "Сплю" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected1;
            Content = new StackLayout { Children = { list } };
        }
        string kell;
        private async void List_ItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    kell = "7:00";
                }
                else if (e.SelectedItemIndex == 1)
                {
                    kell = "8:00";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    kell = "8:10";
                }
                else if (e.SelectedItemIndex == 3)
                {
                    kell = "8:30";
                }
                else if (e.SelectedItemIndex == 4)
                {
                    kell = "12:00";
                }
                else if (e.SelectedItemIndex == 5)
                {
                    kell = "12:30";
                }
                else if (e.SelectedItemIndex == 6)
                {
                    kell = "16:00";
                }
                else if (e.SelectedItemIndex == 7)
                {
                    kell = "23:00";
                }

                await DisplayAlert(kell, text, "Да");
            }
        }

    }

}