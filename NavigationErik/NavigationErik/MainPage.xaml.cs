using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NavigationErik
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //Понедельник
            StackLayout st = new StackLayout();
            Button esm_btn = new Button { Text = "Понедельник", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(esm_btn);
            esm_btn.Clicked += new EventHandler(Btns_Clicked);
            //Вторник
            Button teis_btn = new Button { Text = "Вторник", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(teis_btn);
            teis_btn.Clicked += new EventHandler(Btns_Clicked);
            //Среда
            Button sreda_btn = new Button { Text = "Среда", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(sreda_btn);
            sreda_btn.Clicked += new EventHandler(Btns_Clicked);
            //Четверг
            Button tset_btn = new Button { Text = "Четверг", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(tset_btn);
            tset_btn.Clicked += new EventHandler(Btns_Clicked);
            //Пятница
            Button pjat_btn = new Button { Text = "Пятница", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(pjat_btn);
            pjat_btn.Clicked += new EventHandler(Btns_Clicked);
            //Суббота
            Button syb_btn = new Button { Text = "Суббота", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(syb_btn);
            syb_btn.Clicked += new EventHandler(Btns_Clicked);
            //Воскресенье
            Button vos_btn = new Button { Text = "Воскресенье", ImageSource = "Solntse.png", BackgroundColor = Color.LightBlue };
            st.Children.Add(vos_btn);
            vos_btn.Clicked += new EventHandler(Btns_Clicked);

            Content = st;
        }

        private async void Btns_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Понедельник":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Esmaspaev());
                    break;
                case "Вторник":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Pon());
                    break;
                case "Среда":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Vt());
                    break;
                case "Четверг":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new tsetverg());
                    break;
                case "Пятница":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Pjatnitsa());
                    break;
                case "Суббота":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Sybbota());
                    break;
                case "Воскресенье":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Voskresenje());
                    break;

            }
        }
    }
}
