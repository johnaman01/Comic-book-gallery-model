using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ComicBookGalleryModel.Models
{
    public class Series
    {
        //nav property must be initialized via Series constructor
        public Series()
        {
            ComicBooks = new List<ComicBookArtist>();
        }

        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Title { get; set; }
        public string Description { get; set; }
        //defining a navigation property on principal is optional
        public ICollection<ComicBookArtist> ComicBooks { get; set; }
    }
}
