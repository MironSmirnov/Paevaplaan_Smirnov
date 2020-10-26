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
    public partial class Thursday : ContentPage
    {
        public Thursday()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Учеба", "Автошкола", "Поход в ресторан", "Подготовка к контрольной" };
            ListView list = new ListView();//список для отображения планов
            list.ItemsSource = tasks;//данные из списка планов
            list.ItemSelected += List_ItemSelected1; ;
            Content = new StackLayout { Children = { list } };//отображаем список на странице
        }
        string time;
        private async void List_ItemSelected1(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                string text = e.SelectedItem.ToString();
                if (e.SelectedItemIndex == 0)//Учеба
                {
                    time = "8:30";
                }
                else if (e.SelectedItemIndex == 1)//Автошкола
                {
                    time = "15:30";
                }
                else if (e.SelectedItemIndex == 2)//Поход в ресторан
                {
                    time = "17:00";
                }
                else if (e.SelectedItemIndex == 3)//Подготовка к контрольной
                {
                    time = "19:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}