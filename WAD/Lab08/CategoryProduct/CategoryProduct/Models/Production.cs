using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CategoryProduct.Models
{
    public enum Grade
    {
        A, B, C, D, F
    }

    public class Production
    {
        public int ProductionID { get; set; }
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public Grade? Grade { get; set; }

        public virtual Product Product { get; set; }
        public virtual Category Category { get; set; }
    }
}