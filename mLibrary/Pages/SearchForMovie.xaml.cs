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
    /// Interaction logic for SearchForMovie.xaml
    /// </summary>
    public partial class SearchForMovie : UserControl, INotifyPropertyChanged
    {
        public SearchForMovie()
        {
            InitializeComponent();
            this.movieList = new ObservableCollection<Models.Movie>();
            this.movieInfoList = new ObservableCollection<Models.Movie_info>();
            this.DataContext = this;
        }

        private void btnClickSearch(object sender, RoutedEventArgs e)
        {
            this.movieInfoList.Clear();
            this.MovieInfoList.Clear();

            string movieTitle = this.txbMovieName.Text.ToString();
            Models.Api movieAPI;

            if (movieTitle != "")
            {
                movieAPI = new Models.Api();
                MovieList = movieAPI.FindMovies(movieTitle);

                if (MovieList!=null)
                    foreach (Models.Movie mv in MovieList)
                    {
                        Models.Movie_info movie = movieAPI.FindOne(mv.Id);
                        if (movie.Cover != "")
                            MovieInfoList.Add(movie);
                    }
                else
                {
                    string msg = movieTitle + " is not in our database!";
                    MessageBox.Show(msg);
                }
            }
            else MessageBox.Show("Movie title fieldn can't be empty!");
        }

        //Function for MouseWheelEvent => horizontal offset
        private void ScrollViewer_Loaded(object sender, RoutedEventArgs e)
        {
            this.viewer.AddHandler(MouseWheelEvent, new RoutedEventHandler(MyMouseWheelH), true);
        }

        private void ScrollViewer_UnloadHandler()
        {
            this.viewer.RemoveHandler(MouseWheelEvent, new RoutedEventHandler(MyMouseWheelH));
        }

        private void MyMouseWheelH(object sender, RoutedEventArgs e)
        {
            try
            {
                MouseWheelEventArgs eargs = (MouseWheelEventArgs)e;

                double x = (double)eargs.Delta;

                double y = viewer.HorizontalOffset;
                viewer.ScrollToHorizontalOffset(y - x);
            }
            catch { }
        }

        private ObservableCollection<Models.Movie> movieList;

        private ObservableCollection<Models.Movie_info> movieInfoList;


        public ObservableCollection<Models.Movie> MovieList
        {
            get { return this.movieList; }
            set
            {
                this.movieList = value;
                this.RaisePropertyChanged("MovieList");
            }
        }

        public ObservableCollection<Models.Movie_info> MovieInfoList
        {
            get { return this.movieInfoList; }
            set
            {
                this.movieInfoList = value;
                this.RaisePropertyChanged("MovieInfoList");
            }
        }

        //INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void RaisePropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
 }
