﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paevaplaan
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Tuesday : ContentPage
    {
        public Tuesday()
        {
            //InitializeComponent();
            //План на день
            string[] tasks = new string[] { "Учеба", "Покупка одежды", "Тренировка" };
            ListView list = new ListView();//список для отображения планов
            list.ItemsSource = tasks;//данные из списка планов
            list.ItemSelected += List_ItemSelected1; ;
            Button back = new Button { Text = "back", BackgroundColor = Color.Green, ImageSource = "back.png" };
            back.Clicked += Back_Clicked; ;
            Button next = new Button { Text = "next", BackgroundColor = Color.Green, ImageSource = "next.png" };
            next.Clicked += Next_Clicked; ; ;
            Content = new StackLayout { Children = { list, back, next } };
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Wednesday());
        }

        private async void Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
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
                else if (e.SelectedItemIndex == 1)//Покупка одежды
                {
                    time = "16:00";
                }
                else if (e.SelectedItemIndex == 2)//Тренировка
                {
                    time = "18:00";
                }
                await DisplayAlert(time, text, "jah");
            }
            }
        }
    }