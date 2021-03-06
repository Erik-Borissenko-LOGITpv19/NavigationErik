﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NavigationErik
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sybbota : ContentPage
    {
        public Sybbota()
        {
            Title = "Суббота";
            string[] tasks = new string[] { "Встаю", "Завтракаю", "Иду спать", "Просыпаюсь", "Ем", "Пью", "Сплю", "Все еще сплю" };
            ListView list = new ListView();
            list.ItemsSource = tasks;
            list.ItemSelected += List_ItemSelected1;
            Button gg5 = new Button { Text = "Назад" };
            gg5.Clicked += gg5_Clicked;
            gg5.BackgroundColor = Color.LightBlue;
            gg5.ImageSource = "leftbutton.png";
            Button biba4 = new Button { Text = "Вперед" };
            biba4.Clicked += Biba4_Clicked;
            biba4.BackgroundColor = Color.LightBlue;
            biba4.ImageSource = "vpered.png";
            Content = new StackLayout { Children = { list, gg5, biba4 } };
            BackgroundColor = Color.LightBlue;
        }
        private async void gg5_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
        private async void Biba4_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Voskresenje());
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

                await DisplayAlert(kell, text, "Да хватит уже читать... Нечего читать тут мои планы на успешную жизнь:D");
            }
        }

    }

}