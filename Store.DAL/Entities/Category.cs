﻿using System.Collections.Generic;

namespace Store.DAL.Entities
{
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Good> Goods { get; set; }
    }
}