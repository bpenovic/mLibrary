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


namespace mLibrary.Controls
{
    /// <summary>
    /// Interaction logic for MovieItem.xaml
    /// </summary>
    public partial class MovieItem : UserControl
    {
        public MovieItem()
        {
            InitializeComponent();
        }

        private void btnClickMoreInfo(object sender, RoutedEventArgs e)
        {
            //Id as parameter through button Tag
            string movieID = this.btnMoreInfo.Tag.ToString();

            Window window = new Window();

            window.Content = new Pages.MovieInfo(movieID, window); 
            window.WindowStyle = WindowStyle.None;
            window.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            window.ResizeMode = ResizeMode.NoResize;
            window.Height = 400;
            window.Width = 1024;

            window.ShowDialog();
        }
    }
}
