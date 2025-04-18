using System;
using System.Collections.Generic;

namespace ExamPotapenko_2_04.Models
{
    public partial class AssortmentPizza
    {
        public int IdAssortimentPizza { get; set; }
        public int? IdPizza { get; set; }
        public int? IdPizzaSize { get; set; }
        public int? IdAssortimentPizzaPrice { get; set; }
        public double? Weight { get; set; }

        public AssortimentPizzaPrice IdAssortimentPizzaPriceNavigation { get; set; }
    }
}
