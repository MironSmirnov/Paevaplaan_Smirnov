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
    public partial class Sunday : ContentPage
    {
        public Sunday()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Заказ пиццы", "Уборка", "Поход в магазин", "Подготовка к Понедельнику" };
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
                if (e.SelectedItemIndex == 0)//Заказ пиццы
                {
                    time = "14:00";
                }
                else if (e.SelectedItemIndex == 1)//Уборка
                {
                    time = "15:00";
                }
                else if (e.SelectedItemIndex == 2)//Поход в магазин
                {
                    time = "16:30";
                }
                else if (e.SelectedItemIndex == 3)//Подготовка к Понедельнику
                {
                    time = "19:00";
                }
                await DisplayAlert(time, text, "jah");
            }
        }
    }
}