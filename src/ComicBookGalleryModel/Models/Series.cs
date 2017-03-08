using System.Collections.Generic;

namespace ComicBookGalleryModel.Models
{
    public class Series
    {
        //nav property must be initialized via Series constructor
        public Series()
        {
            ComicBooks = new List<ComicBook>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        //defining a navigation property on principal is optional
        public ICollection<ComicBook> ComicBooks { get; set; }
    }
}
