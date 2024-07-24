using System;
using System.Windows;
using System.Windows.Media;

namespace ThemeApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchToLightTheme(object sender, RoutedEventArgs e)
        {
            ApplyTheme("Themes/LightTheme.xaml");
        }

        private void SwitchToDarkTheme(object sender, RoutedEventArgs e)
        {
            ApplyTheme("Themes/DarkTheme.xaml");
        }

        private void ApplyTheme(string themePath)
        {
            var uri = new Uri(themePath, UriKind.Relative);
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            Application.Current.Resources.MergedDictionaries.Clear();
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }
    }
}
