using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tsarst.PopUps
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnDisplayAlertButton_Clicked(object sender, EventArgs e)
        {
            await DisplayAlert("Уведомление", "Простой попап", "Ок");
        }

        private async void OnDisplayAlertQuestionButton_Clicked(object sender, EventArgs e)
        {
            bool result = await DisplayAlert("Вопрос", "Пойти на работу?", "Да", "Нет");

            if (result)
            {
                await DisplayAlert("Ответ", "Молодец!", "Ок");
            }
        }

        private async void OnDisplayActionSheetButton_Clicked(object sender, EventArgs e)
        {
            string action = await DisplayActionSheet("Какой цвет?", null, null, "Красный", "Жёлтый", "Зелёный");

            await DisplayAlert("Результат", action, "ОК");
        }
    }
}
