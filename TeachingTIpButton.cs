using Microsoft.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace TeachingTipCrash
{
    public class TeachingTipButton : Button
    {
        public TeachingTipButton()
        {
            this.Click += TeachingTipButton_Click;
        }

        public static readonly DependencyProperty TeachingTipProperty = DependencyProperty.Register(
            nameof(TeachingTip),
            typeof(TeachingTip),
            typeof(TeachingTipButton),
            new PropertyMetadata(null, TeachingTip_Changed)
            );

        public TeachingTip TeachingTip
        {
            get => (TeachingTip)GetValue(TeachingTipProperty);
            set => SetValue(TeachingTipProperty, value);
        }

        private static void TeachingTip_Changed(DependencyObject obj, DependencyPropertyChangedEventArgs args)
        {
            var button = (TeachingTipButton)obj;
            var teachingTip = (TeachingTip)args.NewValue;
            teachingTip.Target = button;
        }

        private void TeachingTipButton_Click(object sender, RoutedEventArgs args)
        {
            TeachingTip.IsOpen = true;
        }
    }
}