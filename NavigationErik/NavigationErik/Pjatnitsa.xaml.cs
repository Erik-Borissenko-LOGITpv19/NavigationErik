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
    public partial class Pjatnitsa : ContentPage
    {
        public Pjatnitsa()
        {
            Title = "Пятница";
            string[] tasks = new string[] { "Понедельник", "Встаю", "Завтракаю", "Иду в тех", "Учусь", "Ем", "Учусь", "Иду домой", "Сплю" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected1;
            Button gg3 = new Button { Text = "Назад" };
            gg3.Clicked += gg3_Clicked;
            gg3.BackgroundColor = Color.LightBlue;
            gg3.ImageSource = "leftbutton.png";
            Button biba2 = new Button { Text = "Вперед" };
            biba2.Clicked += Biba2_Clicked;
            biba2.BackgroundColor = Color.LightBlue;
            biba2.ImageSource = "vpered.png";
            Content = new StackLayout { Children = { list, gg3, biba2 } };
            BackgroundColor = Color.LightBlue;

        }
        private async void Biba2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Sybbota());
        }
        private async void gg3_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        string kell;
        private async void List_ItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)
                {
                    kell = "ЭРИК!!! СЕГОДНЯ ПОНЕДЕЛЬНИК!!!";
                }
                if (e.SelectedItemIndex == 1)
                {
                    kell = "7:00";
                }
                else if (e.SelectedItemIndex == 2)
                {
                    kell = "8:00";
                }
                else if (e.SelectedItemIndex == 3)
                {
                    kell = "8:10";
                }
                else if (e.SelectedItemIndex == 4)
                {
                    kell = "8:30";
                }
                else if (e.SelectedItemIndex == 5)
                {
                    kell = "12:00";
                }
                else if (e.SelectedItemIndex == 6)
                {
                    kell = "12:30";
                }
                else if (e.SelectedItemIndex == 7)
                {
                    kell = "16:00";
                }
                else if (e.SelectedItemIndex == 8)
                {
                    kell = "23:00";
                }

                await DisplayAlert(kell, text, "Да хватит уже читать... Нечего читать тут мои планы на успешную жизнь:D");
            }
        }

    }

}