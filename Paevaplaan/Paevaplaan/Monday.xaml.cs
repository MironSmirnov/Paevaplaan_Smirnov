using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paevaplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Monday : ContentPage
    {
        public Monday()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Учеба", "Гуляю", "Иду на ночевку" };
            ListView list = new ListView();//список для отображения планов
            list.ItemsSource = tasks;//данные из списка планов
            list.ItemSelected += List_ItemSelected;
            Content = new StackLayout { Children = { list } };//отображаем список на странице
        }
        string time;
        private async void List_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//Учеба
                {
                    time = "8:30";
                }
                else if (e.SelectedItemIndex == 1)//Гуляю
                {
                    time = "17:00";
                }
                else if (e.SelectedItemIndex == 2)//Иду ночевку
                {
                    time = "21:00";
                }
                await DisplayAlert(time, text, "Jah");
            }
        }
    }
}