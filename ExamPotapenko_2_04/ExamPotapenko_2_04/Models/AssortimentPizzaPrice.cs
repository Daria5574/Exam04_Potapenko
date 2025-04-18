using System;
using System.Collections.Generic;

namespace ExamPotapenko_2_04.Models
{
    public partial class AssortimentPizzaPrice
    {
        public AssortimentPizzaPrice()
        {
            AssortmentPizza = new HashSet<AssortmentPizza>();
        }

        public int IdAssortimentPizzaPrice { get; set; }
        public double? Price { get; set; }

        public ICollection<AssortmentPizza> AssortmentPizza { get; set; }
    }
}
