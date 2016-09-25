using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WomanTranslator.Mobile.Infrastructure;
using Xamarin.Forms;

namespace WomanTranslator.Mobile
{
    public partial class MainPage : ContentPage
    {
        private readonly Translator _translator = new Translator();
        public MainPage()
        {
            InitializeComponent();

            if (Device.OS == TargetPlatform.Android)
            {
                var buttonFactory = DependencyService.Get<IButtonFactory>();
                var btn = buttonFactory.BuildButton("Traducir", () => BtnTraducir_OnClicked(null, null));
                GridContainer.Children.Add(btn);
            }
            else
            {
                var button= new Button()
                {
                    Text = "Traducir"
                };
                button.Clicked += BtnTraducir_OnClicked;
                StackContainer.Children.Add(button);
            }
        }

        private async void BtnTraducir_OnClicked(object sender, EventArgs e)
        {
            var original = TxtInput.Text;
            if (string.IsNullOrWhiteSpace(original))
            {
                return;
            }

            var resultado = _translator.Translate(original);
            await Application.Current.MainPage.DisplayAlert("Traduccion", resultado, "Ok");
        }
    }
}
