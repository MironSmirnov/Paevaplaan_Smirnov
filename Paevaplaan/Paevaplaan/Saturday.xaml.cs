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
    public partial class Saturday : ContentPage
    {
        public Saturday()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Выезд из отеля", "Поездка в другой город", "Возвращение домой", "Прогулка с друзьями" };
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
                if (e.SelectedItemIndex == 0)//Выезд из отеля
                {
                    time = "12:00";
                }
                else if (e.SelectedItemIndex == 1)//Поездка в другой город
                {
                    time = "14:00";
                }
                else if (e.SelectedItemIndex == 2)//Возвращение домой
                {
                    time = "17:00";
                }
                else if (e.SelectedItemIndex == 3)//Прогулка с друзьями
                {
                    time = "19:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}