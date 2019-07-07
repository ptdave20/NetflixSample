using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace NetflixSample.Model
{
    public class MainPageModel : INotifyPropertyChanged
    {
        public MainPageModel()
        {
            Sections = new ObservableCollection<Section>();
        }
        public ObservableCollection<Section> Sections { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }


    public class Section : INotifyPropertyChanged
    {
        public string SectionName { get; set; }
        public ObservableCollection<Show> Shows { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class Show : INotifyPropertyChanged
    {
        public string ShowName { get; set; }
        public ShowType ShowType { get; set; }
        public string ShowImage { get; set; }
        public int ShowYear { get; set; }
        public string ShowDescription { get; set; }
        public string ShowStarring { get; set; }
        public string ShowCreator { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public enum ShowType : int
    {
        Movie = 0,
        TV = 1
    }
}
