using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public DateTime VacationStartDate { get; set; }
        public DateTime VacationEndDate { get; set; }
        public string RegularPickupDay { get; set; }
    }
}