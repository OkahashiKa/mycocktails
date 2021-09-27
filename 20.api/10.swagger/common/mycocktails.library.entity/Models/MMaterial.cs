﻿using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MMaterial
    {
        public MMaterial()
        {
            MCocktailRecipis = new HashSet<MCocktailRecipi>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

        public virtual MMaterialCategory Category { get; set; }
        public virtual ICollection<MCocktailRecipi> MCocktailRecipis { get; set; }
    }
}
