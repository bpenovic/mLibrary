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
using System.ComponentModel;
using System.Collections.ObjectModel;


namespace mLibrary.Pages
{
    /// <summary>
    /// Interaction logic for MovieInfo.xaml
    /// </summary>
    public partial class MovieInfo : UserControl
    {
        string movieID = "";
        Models.Api movieAPI = null;
        Models.Movie_info movieInfo = null;
        string msg = "";
        Window parentWindow = null;

        public MovieInfo(string movieID, Window parentWindow)
        {
            InitializeComponent();
            this.movieID = movieID;
            this.parentWindow = parentWindow;

            movieAPI = new Models.Api();
            movieInfo = movieAPI.FindOne(movieID);

            this.DataContext = movieInfo;
        }

        private void btnClickClose(object sender, RoutedEventArgs e)
        {
            parentWindow.Close();
        }



        //IntroVIewer Scrolling
        private void IntroViewerLoaded(object sender, RoutedEventArgs e)
        {

            this.IntroViewer.AddHandler(MouseWheelEvent, new RoutedEventHandler(IntroWheelH), true);
        }

        private void IntroWheelH(object sender, RoutedEventArgs e)
        {
            try
            {
                MouseWheelEventArgs eargs = (MouseWheelEventArgs)e;

                double x = (double)eargs.Delta;

                double y = IntroViewer.HorizontalOffset;
                IntroViewer.ScrollToHorizontalOffset(y - x);
            }
            catch { }
        }

        //PlotViewer Scrolling
        private void PlotViewerLoaded(object sender, RoutedEventArgs e)
        {

            this.PlotViewer.AddHandler(MouseWheelEvent, new RoutedEventHandler(PlotWheelH), true);
        }

        private void PlotWheelH(object sender, RoutedEventArgs e)
        {
            try
            {
                MouseWheelEventArgs eargs = (MouseWheelEventArgs)e;

                double x = (double)eargs.Delta;

                double y = PlotViewer.HorizontalOffset;
                PlotViewer.ScrollToHorizontalOffset(y - x);
            }
            catch { }
        }

        //CastViewer Scrolling
        private void CastViewerLoaded(object sender, RoutedEventArgs e)
        {

            this.CastViewer.AddHandler(MouseWheelEvent, new RoutedEventHandler(CastWheelH), true);
        }

        private void CastWheelH(object sender, RoutedEventArgs e)
        {
            try
            {
                MouseWheelEventArgs eargs = (MouseWheelEventArgs)e;

                double x = (double)eargs.Delta;

                double y = CastViewer.HorizontalOffset;
                CastViewer.ScrollToHorizontalOffset(y - x);
            }
            catch { }
        }

        //UnloadHandler on ScrollViewers
        private void ScrollViewer_UnloadHandler()
        {
            this.IntroViewer.RemoveHandler(MouseWheelEvent, new RoutedEventHandler(IntroWheelH));
            this.PlotViewer.RemoveHandler(MouseWheelEvent, new RoutedEventHandler(PlotWheelH));
            this.CastViewer.RemoveHandler(MouseWheelEvent, new RoutedEventHandler(CastWheelH));
        }
    }
}
