using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

//Json dll
using Newtonsoft.Json.Linq;

namespace mLibrary.Models
{
    public class Movie: INotifyPropertyChanged
    {
        string id, year;
        string title, poster, type;

        //public Movie(string json)
        //{
        //    JObject jObject = JObject.Parse(json);
        //    JToken jMovie = jObject[""];

        //    id = int.Parse( (string)jMovie["id"] );
        //    year = int.Parse( (string)jMovie["year"] );
        //    title = (string)jMovie["title"];
        //    type = (string)jMovie["type"];
        //    poster = (string)jMovie["poster"];
        //}

        public string Id
        {
            get { return id; }
            set
            {
                id = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Id"));
                }
            }
        }


        public string Year
        {
            get { return year; }
            set
            {
                
                    year = value;
            }
        }

        public string Title
        {
            get { return title; }
            set {
                title = value;

                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Title"));
                }
            }
        }

        public string Poster
        {
            get { return poster; }
            set { poster = value; }
        }
        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
