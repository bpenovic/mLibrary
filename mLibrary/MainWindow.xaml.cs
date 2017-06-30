using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms.Integration;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

// MetroFramework 
using MahApps.Metro.Controls;

//Controls
using mLibrary.Controls;

namespace mLibrary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void btnClickSearchForMovie(object sender, RoutedEventArgs e)
        {

            MainContainer.Content = new Pages.SearchForMovie();
            panelAboutApp.Visibility = Visibility.Hidden;
        }

        private void btnClickFindMovie(object sender, RoutedEventArgs e)
        {
            MainContainer.Content = new Pages.SearchForMovie();
            panelAboutApp.Visibility = Visibility.Hidden;
        }
    }
}
