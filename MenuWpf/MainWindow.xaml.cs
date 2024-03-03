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

namespace MenuWpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int currentProfile = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int index=(int)slider.Value;
            switch(index) 
            {
                case 0:
                    bord1.Visibility = Visibility.Visible;
                    bord2.Visibility = Visibility.Collapsed;
                    bord3.Visibility = Visibility.Collapsed;
                    bord4.Visibility = Visibility.Collapsed;
                    break;
                case 1:
                    bord1.Visibility = Visibility.Collapsed;
                    bord2.Visibility = Visibility.Visible;
                    bord3.Visibility = Visibility.Collapsed;
                    bord4.Visibility = Visibility.Collapsed;
                    break;
                case 2:
                    bord1.Visibility = Visibility.Collapsed;
                    bord2.Visibility = Visibility.Collapsed;
                    bord3.Visibility = Visibility.Visible;
                    bord4.Visibility = Visibility.Collapsed;
                    break;
                case 3:
                    bord1.Visibility = Visibility.Collapsed;
                    bord2.Visibility = Visibility.Collapsed;
                    bord3.Visibility = Visibility.Collapsed;
                    bord4.Visibility = Visibility.Visible;
                    break;

            }
        }

        private void next_Click(object sender, RoutedEventArgs e)
        {
            currentProfile++;
            if (currentProfile > 3)
            {
                currentProfile = 0;
            }
            slider.Value = currentProfile;
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {
            currentProfile--;
            if (currentProfile < 0)
            {
                currentProfile = 3;
            }
            slider.Value = currentProfile;
        }
    }
}
