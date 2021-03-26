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

namespace kostyaTerminator2000
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
        private void imagePanel_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.GetPosition(imagePanel);
            string foo = mousePosition.X.ToString();
            ayeText.Text = foo;
            double imageWidth = imagePanel.ActualWidth;

            if (mousePosition.X <= imageWidth * 1/3)
            {
                imagePanel.Source = new BitmapImage(new Uri(@"Images/meinRespecturing.jpg", UriKind.Relative));
                firstRadioButton.IsChecked = true;
                secondRadioButtton.IsChecked = false;
                thirdRadioButton.IsChecked = false;
            }

            if (mousePosition.X > imageWidth * 1/3 && mousePosition.X < imageWidth * 2/3)
            {
                imagePanel.Source = new BitmapImage(new Uri(@"Images/kaneki.jpg", UriKind.Relative));
                firstRadioButton.IsChecked = false;
                secondRadioButtton.IsChecked = true;
                thirdRadioButton.IsChecked = false;
            }

            if (mousePosition.X >= imageWidth * 2/3)
            {
                imagePanel.Source = new BitmapImage(new Uri(@"Images/coolMonke.png", UriKind.Relative));
                firstRadioButton.IsChecked = false;
                secondRadioButtton.IsChecked = false;
                thirdRadioButton.IsChecked = true;
            }

        }
    }
}
