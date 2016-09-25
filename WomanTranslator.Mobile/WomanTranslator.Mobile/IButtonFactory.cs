using System;
using Xamarin.Forms;

namespace WomanTranslator.Mobile
{
    public interface IButtonFactory
    {
        View BuildButton(string text, Action onClicked);
    }
}