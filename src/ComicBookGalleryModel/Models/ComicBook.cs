using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel.Models
{
    public class ComicBook
    {
        public int Id { get; set; }

        public int IssueNumber { get; set; }
        public string Description { get; set; }
        public DateTime PublishedOn { get; set; }
        public decimal? AverageRating { get; set; }
        public string DisplayText
        {
            //read-only or getter-only property
            get
            {
                //interpolated string with null conditional operator
                return $"{Series?.Title} # {IssueNumber}";

            }
        }

        public Series Series { get; set; }


    }
}
