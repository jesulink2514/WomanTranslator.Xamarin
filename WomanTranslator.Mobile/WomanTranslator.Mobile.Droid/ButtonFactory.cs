using System;
using Android.Runtime;
using Android.Support.Design.Widget;
using WomanTranslator.Mobile.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using View = Xamarin.Forms.View;

[assembly:Dependency(typeof(ButtonFactory))]
namespace WomanTranslator.Mobile.Droid
{
    [Preserve]
    public class ButtonFactory : IButtonFactory
    {
        public View BuildButton(string text, Action onClicked)
        {
            var context = Forms.Context;
            var button = new FloatingActionButton(context);
            button.SetImageResource(Resource.Drawable.translate);
            button.Click += (sender, args) => onClicked();
            var view = button.ToView();
            view.HorizontalOptions = LayoutOptions.End;
            view.VerticalOptions = LayoutOptions.End;
            view.Margin = 20;
            return view;
        }
    }
}