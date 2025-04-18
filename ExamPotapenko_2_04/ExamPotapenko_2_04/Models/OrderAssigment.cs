using System;
using System.Collections.Generic;

namespace ExamPotapenko_2_04.Models
{
    public partial class OrderAssigment
    {
        public int IdOrderAssortment { get; set; }
        public double? IdOrder { get; set; }
        public double? IdAssortiment { get; set; }
        public double? Quantity { get; set; }
    }
}
