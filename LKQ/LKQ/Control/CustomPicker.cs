using System;
using Xamarin.Forms;

namespace LKQ.Control
{
    public class CustomPicker : Picker
    {
        public static readonly BindableProperty ImageProperty =
             BindableProperty.Create(nameof(Image), typeof(string), typeof(CustomPicker), string.Empty);
        public static BindableProperty CornerRadiusProperty =
          BindableProperty.Create(nameof(CornerRadius), typeof(int), typeof(CustomEntry), 0);
        public static BindableProperty BorderColorProperty =
         BindableProperty.Create(nameof(BorderColor), typeof(Color), typeof(CustomEntry), Color.Transparent);

        public static BindableProperty BorderThicknessProperty =
            BindableProperty.Create(nameof(BorderThickness), typeof(int), typeof(CustomEntry), 0);
        public int CornerRadius
        {
            get => (int)GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }

        public int BorderThickness
        {
            get => (int)GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        public Color BorderColor
        {
            get => (Color)GetValue(BorderColorProperty);
            set => SetValue(BorderColorProperty, value);
        }
        public string Image
        {
            get { return (string)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }
    }
}
