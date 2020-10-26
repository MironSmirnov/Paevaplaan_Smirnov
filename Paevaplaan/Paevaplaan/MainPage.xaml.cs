using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Paevaplaan
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            StackLayout stack = new StackLayout();
            Button Mon_btn = new Button { Text = "Monday" };
            stack.Children.Add(Mon_btn);
            Mon_btn.Clicked += new EventHandler(btn_Clicked);
            BackgroundColor = Color.Red;

            Content = stack;

            Button Tue_btn = new Button { Text = "Tuesday" };
            stack.Children.Add(Tue_btn);
            Tue_btn.Clicked += new EventHandler(btn_Clicked);
            BackgroundColor = Color.Green;

            Content = stack;

            Button Wed_btn = new Button { Text = "Wednesday" };
            stack.Children.Add(Wed_btn);
            Wed_btn.Clicked += new EventHandler(btn_Clicked);
            

            Content = stack;

            Button Thur_btn = new Button { Text = "Thursday" };
            stack.Children.Add(Thur_btn);
            Thur_btn.Clicked += new EventHandler(btn_Clicked);

            Content = stack;

            Button Frid_btn = new Button { Text = "Friday" };
            stack.Children.Add(Frid_btn);
            Frid_btn.Clicked += new EventHandler(btn_Clicked);

            Content = stack;

            Button Satur_btn = new Button { Text = "Saturday" };
            stack.Children.Add(Satur_btn);
            Satur_btn.Clicked += new EventHandler(btn_Clicked);

            Content = stack;

            Button Sun_btn = new Button { Text = "Sunday" };
            stack.Children.Add(Sun_btn);
            Sun_btn.Clicked += new EventHandler(btn_Clicked);

            Content = stack;
        }

        private async void btn_Clicked(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            switch (btn.Text)
            {
                case "Monday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Monday());
                    break;
                case "Tuesday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Tuesday());
                    break;
                case "Wednesday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Wednesday());
                    break;
                case "Thursday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Thursday());
                    break;
                case "Friday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Friday());
                    break;
                case "Saturday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Saturday());
                    break;
                case "Sunday":
                    await Navigation.PopAsync();
                    await Navigation.PushAsync(new Sunday());
                    break;
            }
        }
    }
}
