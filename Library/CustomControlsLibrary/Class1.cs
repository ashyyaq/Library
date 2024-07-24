namespace CustomControlsLibrary
{
    public enum AppTheme
    {
        Light,
        Dark
    }

    public class CustomButton : Button
    {
        public static readonly DependencyProperty ThemeProperty =
            DependencyProperty.Register("Theme", typeof(AppTheme), typeof(CustomButton),
                new FrameworkPropertyMetadata(AppTheme.Light, FrameworkPropertyMetadataOptions.AffectsRender));

        public AppTheme Theme
        {
            get { return (AppTheme)GetValue(ThemeProperty); }
            set { SetValue(ThemeProperty, value); }
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            // Определяем цвет фона в зависимости от темы
            if (Theme == AppTheme.Light)
            {
                Background = Brushes.White;
                Foreground = Brushes.Black;
            }
            else
            {
                Background = Brushes.Black;
                Foreground = Brushes.White;
            }
        }
    }
}