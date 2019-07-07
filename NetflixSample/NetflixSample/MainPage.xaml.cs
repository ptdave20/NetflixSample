using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NetflixSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new Model.MainPageModel()
            {
                Sections = new System.Collections.ObjectModel.ObservableCollection<Model.Section>()
                {
                    new Model.Section()
                    {
                        SectionName = "Critically Acclaimed Witty TV Shows",
                        Shows = new System.Collections.ObjectModel.ObservableCollection<Model.Show>()
                        {
                            new Model.Show()
                            {
                                ShowName = "The Office",
                                ShowImage = "https://upload.wikimedia.org/wikipedia/en/5/58/TheOffice_S7_DVD.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Tales of the City",
                                ShowImage = "http://www.gstatic.com/tv/thumb/tvbanners/16798930/p16798930_b_v8_ac.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Parks and Recreation",
                                ShowImage = "http://www.gstatic.com/tv/thumb/tvbanners/11312594/p11312594_b_v8_aa.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Comedians in Cars Getting Coffee",
                                ShowImage = "http://www.gstatic.com/tv/thumb/tvbanners/9364219/p9364219_b_v8_ad.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Documentary Now",
                                ShowImage = "https://image.tmdb.org/t/p/original//slgTBlUVBU3e3g4R7pVnmfmq8vi.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Patriot Act",
                                ShowImage = "https://pbs.twimg.com/media/Dqjo94fX0AACwI8.jpg"
                            },

                        },
                        
                    },
                    new Model.Section()
                    {
                        SectionName = "Trending Now",
                        Shows = new System.Collections.ObjectModel.ObservableCollection<Model.Show>()
                        {
                            new Model.Show()
                            {
                                ShowName = "Frasier",
                                ShowImage = "https://occ-0-116-114.1.nflxso.net/art/69a09/e087916d4cd799613792c47be25fe6354de69a09.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "The Office",
                                ShowImage = "https://upload.wikimedia.org/wikipedia/en/5/58/TheOffice_S7_DVD.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Outlander",
                                ShowImage = "http://eecarter.com/wordpress/wp-content/uploads/2016/06/Outlander-TV_series-2014.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Criminal Minds",
                                ShowImage = "https://i.pinimg.com/736x/d0/27/d1/d027d19026d1349a6cf8d283017c8bd8.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "The Great British Baking Show",
                                ShowImage = "https://dnm.nflximg.net/api/v6/XsrytRUxks8BtTRf9HNlZkW2tvY/AAAAAaorsPuulQRiXyuQyd4fUU4_BTgf9P_KGYhQNAbzCQK19vvvJl8RWu84-pHgSMWdxswW-H4f7AAhxq6QrKV9c788EarVXVH0Eg.jpg?r=b24"
                            },
                            new Model.Show()
                            {
                                ShowName = "The Hangover",
                                ShowImage = "https://assets.nflxext.com/us/boxshots/hd1080/70113002.jpg"
                            }
                        }
                    },
                    new Model.Section()
                    {
                        SectionName = "TV Shows from the 1990s",
                        Shows = new System.Collections.ObjectModel.ObservableCollection<Model.Show>()
                        {
                            new Model.Show()
                            {
                                ShowName = "Star Trek Voyager",
                                ShowImage = "https://occ-0-999-1001.1.nflxso.net/art/4c8c0/450bc933cb8d25bdbf429558d60fabeb4b84c8c0.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Charmed",
                                ShowImage = "https://dnm.nflximg.net/api/v6/XsrytRUxks8BtTRf9HNlZkW2tvY/AAAAAVGOYiFsuLRBFduhOYsCRRZZnIY7nW5hbEjKkUhmghnxOMHljwUA49CJG9087qUP_gBkOptqRWPa3HTsP9ppEIsThOgrmQWLWg.jpg?r=8ce"
                            },
                            new Model.Show()
                            {
                                ShowName = "The Magic School Bus",
                                ShowImage = "https://m.media-amazon.com/images/M/MV5BMTY0MjA5Mjc4Ml5BMl5BanBnXkFtZTgwNDE2NDMzNTM@._V1_.jpg"
                            },
                            new Model.Show()
                            {
                                ShowName = "Goosebumps",
                                ShowImage = "https://assets.nflxext.com/us/boxshots/hd1080/80049939.jpg",
                            },
                            new Model.Show()
                            {
                                ShowName = "Adventures of Sonic the Hedgehog",
                                ShowImage = "https://occ-0-114-116.1.nflxso.net/art/6f2db/60e2e1d1f07bba7f5cd8c05393a731fe0766f2db.jpg"
                            }
                        }
                    }
                }
            };
        }
    }
}
