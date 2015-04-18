using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicReader.ViewModels
{
    public class LibraryViewModel : ViewModelBase
    {
        private ObservableCollection<string> _covers = new ObservableCollection<string> { 
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.blueboxsports.com/bbs/wp-content/uploads/2013/09/v5feat_200-comic-book-heroe.jpg",
            "http://assets.nydailynews.com/polopoly_fs/1.45607.1313760142!/img/httpImage/image.jpg_gen/derivatives/gallery_1200/gal-comics-amazing-fantasy-15-jpg.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg",
            "http://www.wired.com/images_blogs/underwire/2009/12/1982-wolverine-1-4.jpg"
        };

        public ObservableCollection<string> Covers
        {
            get { return _covers; }
            set { SetProperty(ref _covers, value, "Covers");  }
        }
    }
}
