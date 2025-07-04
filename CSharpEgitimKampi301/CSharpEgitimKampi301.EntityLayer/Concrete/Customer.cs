﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Customer
    {
        public int CustomerID { get; set; }

        public string CustomerName { get; set; }

        public string CustomerSurname { get; set; }

        public string CustomerDistrict { get; set; }

        public string CustomerCity { get; set; }

        public List<Order> Orders { get; set; }

        public bool CustomerStatus { get; set; }

        /*
         
        SOLID

        Single Responsibility --> Tek Sorumluluk

         */
    }
}
