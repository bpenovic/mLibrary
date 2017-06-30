using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace mLibrary.Models
{
    public class Movie_info : Movie, INotifyPropertyChanged
    {
        // Movie => id, title, year, poster, type
        string director, writer, cined, production, countries, gen, plot, plotout, cast;
        string cover = "";
        string duration; // its not int because there is not same format every time
        string rate; // its not int because there is not same format every time

        Boolean isFavorite = false;

        Visibility isVisible = Visibility.Visible;

        public string Director
        {
            get { return director; }
            set
            {
                director = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover"));
                }
            }
        }

        public string Writer
        {
            get { return writer; }
            set
            {
                writer = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover"));
                }
            }
        }

        public string Cined
        {
            get { return cined; }
            set
            {
                cined = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover"));
                }
            }
        }

        public string Production
        {
            get { return production; }
            set
            {
                production = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover"));
                }
            }
        }

        public string Countries
        {
            get { return countries; }
            set
            {
                countries = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover"));
                }
            }
        }

        public string Cover
        {
            get { return cover; }
            set
            {
                cover = value;
                if(Cover=="")
                    IsVisible= Visibility.Hidden;

                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cover")); 
                }
            }
        }

        public Boolean IsFavorite
        {
            get { return isFavorite; }
            set
            {
                isFavorite = value;

                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("IsFavorite"));
                }
            }
        }

        public Visibility IsVisible
        {
            get { return isVisible; }
            set
            {
                isVisible = value;

                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("IsVisible"));
                }
            }
        }

        public string Gen
        {
            get { return gen; }
            set
            {
                gen = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Gen"));
                }
            }
        }

        public string Plot
        {
            get { return plot; }
            set
            {
                plot = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Plot"));
                }
            }
        }

        public string Plotout
        {
            get { return plotout; }
            set
            {
                plotout = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Plotout"));
                }
            }
        }

        public string Cast
        {
            get { return cast; }
            set
            {
                cast = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Cast"));
                }
            }
        }

        public string Duration
        {
            get { return duration; }
            set
            {
                duration = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Duration"));
                }
            }
        }

        public string Rate
        {
            get { return rate; }
            set
            {
                rate = value;
                if (PropChanged != null)
                {
                    PropChanged(this, new PropertyChangedEventArgs("Rate"));
                }
            }
        }

        public event PropertyChangedEventHandler PropChanged;
    }
}
