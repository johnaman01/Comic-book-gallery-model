using ComicBookGalleryModel.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGalleryModel
{
    class Context : DbContext
    {
        public DbSet<ComicBook> ComicBooks { get; set; }
    }
}
