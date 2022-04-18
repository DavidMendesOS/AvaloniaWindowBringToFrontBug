using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace WindowGlitch
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var panel = new StackPanel
            {
                Orientation = Avalonia.Layout.Orientation.Horizontal,
                HorizontalAlignment = Avalonia.Layout.HorizontalAlignment.Center,
                VerticalAlignment = Avalonia.Layout.VerticalAlignment.Center
            };
            
            var showWindow = new Button();
            showWindow.Click += Show_Window;
            showWindow.Content = "Show Window";
            
            panel.Children.Add(showWindow);

            Content = panel;
        }

        private void Show_Window(object? sender, RoutedEventArgs e)
        {
            
            var grid = new Grid
            {
                Background = new SolidColorBrush(Colors.WhiteSmoke),
                Children = { new TextBlock()
                {
                    Text = "Bring to Front", Margin = new Thickness(100)
                } }
            };
            
            var newWindow = new Window()
            {
                Content = grid,
                Height = 300,
                Width = 300,
                Position = new PixelPoint(0,0),
                SystemDecorations = SystemDecorations.Full
            };
            
            newWindow.Show(this);
            
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}