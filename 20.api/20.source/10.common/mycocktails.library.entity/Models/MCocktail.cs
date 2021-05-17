using System;
using System.Collections.Generic;

#nullable disable

namespace mycocktails.library.entity.Models
{
    public partial class MCocktail
    {
        public MCocktail()
        {
            TCocktailMaterials = new HashSet<TCocktailMaterial>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Remarks { get; set; }
        public byte[] Image { get; set; }
        public DateTime? CreateAt { get; set; }
        public DateTime? UpdateAt { get; set; }

        public virtual ICollection<TCocktailMaterial> TCocktailMaterials { get; set; }
    }
}
