﻿using System;
using System.Collections.Generic;

namespace DB_First_demo1.Models
{
    public partial class Category
    {
        public Category()
        {
            Product1s = new HashSet<Product1>();
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = null!;

        public virtual ICollection<Product1> Product1s { get; set; }
    }
}
