﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropdownList_Example.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public  string CategoryName { get; set; }

        public SelectList CategoryList { get; set; } 
    }
}