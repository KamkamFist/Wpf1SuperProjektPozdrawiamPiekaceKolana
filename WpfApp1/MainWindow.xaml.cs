using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
      
        private void RedSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            RedCount.Content = Math.Round(RedSlider.Value);
        }

        private void GreenSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            GreenCount.Content = Math.Round(GreenSlider.Value);
        }

        private void BlueSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            BlueCount.Content = Math.Round(BlueSlider.Value);
        }
        private void UpdateColor()
        {
            byte r = (byte)Math.Round(RedSlider.Value);
            byte g = (byte)Math.Round(GreenSlider.Value);
            byte b = (byte)Math.Round(BlueSlider.Value);
            ColorRectangle.Fill = new SolidColorBrush(Color.FromRgb(r, g, b));
            rgbLabel.Content = $"{r}, {g}, {b}";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateColor();
        }
    }
}