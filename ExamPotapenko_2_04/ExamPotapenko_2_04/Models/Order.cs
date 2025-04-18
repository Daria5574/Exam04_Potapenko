using System;
using System.Collections.Generic;

namespace ExamPotapenko_2_04.Models
{
    public partial class Order
    {
        public double IdOrder { get; set; }
        public string ClientLname { get; set; }
        public string ClientFname { get; set; }
        public string ClientSname { get; set; }
        public string DeliveryStreet { get; set; }
        public double? DeliveryHome { get; set; }
        public string DeliveryApartment { get; set; }
        public string Phone { get; set; }
        public DateTime? OrderDate { get; set; }
        public double? Cost { get; set; }
        public string FullName => $"{ClientLname} {ClientFname} {ClientSname}";
    }
}
