using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewPaper.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public int NewsId { get; set; }
        public string Conten { get; set; }
        public string Title { get; set; }

        public virtual News News { get; set; }
    }
}
