using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CabManagment.Models
{
    public class Customer_Support
    {
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public int OrderID { get; set; }
        public string OrderDate { get; set; }
        public string problem { get; set; }
    }
}