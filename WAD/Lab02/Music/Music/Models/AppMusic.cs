﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Drawing.Printing;
using System.Linq;
using System.Web;

namespace Music.Models
{
    public class AppMusic
    {
        [ScaffoldColumn(false)]
        public int MusicID { get; set; }

        [Required, StringLength(100), Display(Name = "Name")]
        public string MusicName { get; set; }

        [Required, StringLength(10000), Display(Name = "Music Description"), DataType(DataType.MultilineText)]
        public string Description { get; set; }

        public string ImagePath { get; set; }

        [Display(Name = "Price")]
        public double? UnitPrice { get; set; }

        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
    }
}