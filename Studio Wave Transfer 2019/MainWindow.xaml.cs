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

namespace Studio_Wave_Transfer_2019
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       


        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new System.Uri("Pages/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void LogoutPopUpButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void CloseMenuButton_Click(object sender, RoutedEventArgs e)
        {
            OpenMenuButton.Visibility = Visibility.Visible;
            CloseMenuButton.Visibility = Visibility.Collapsed;
        }

        private void OpenMenuButton_Click(object sender, RoutedEventArgs e)
        {
            CloseMenuButton.Visibility = Visibility.Visible;
            OpenMenuButton.Visibility = Visibility.Collapsed;

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void MainMenuButton_GotFocus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Pages/MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void FoldersMenuButton_GotFocus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Pages/FoldersPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void SettingMenuButton_GotFocus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Pages/SettingsPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void AboutMenuButton_GotFocus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Pages/AboutPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void DictionaryMenuButton_GotFocus(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new System.Uri("Pages/DictionaryPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
