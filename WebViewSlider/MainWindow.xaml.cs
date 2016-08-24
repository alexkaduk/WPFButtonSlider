using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WebViewSlider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[][] urls = new string[][]
            {
                new string[] { "http://google.com", "http://yandex.ru" },
                new string[] { "http://news.google.com", "http://news.yander.ru" },
                new string[] { "http://gmail.com", "http://mail.yander.ru" }
            };

        Slider webViewSlider;

        public MainWindow()
        {
            InitializeComponent();

            try
            {
                webViewSlider = new Slider(currentWrap, urls);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Left:
                    webViewSlider.ScrollWebView(0);
                    break;

                case Key.Up:
                    webViewSlider.ScrollWebView(1);
                    break;

                case Key.Right:
                    webViewSlider.ScrollWebView(2);
                    break;

                case Key.Down:
                    webViewSlider.ScrollWebView(3);
                    break;

                default:
                    break;
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //this.Title = currentWrap.ActualWidth.ToString();
            webViewSlider.SetWidthHeight();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            //this.Title = currentWrap.ActualWidth.ToString();
            webViewSlider.SetWidthHeight();
        }
    }
}
