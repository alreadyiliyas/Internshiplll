﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice04.DAL
{
    public class Account
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public bool isActive { get; set; }
        public double Balance { get; set; }
        public int Currency { get; set; }
        public string _number;
        public string Number 
        {
            get
            {
                return _number;
            }
            set
            {
                if (!value.StartsWith("KZ"))
                    _number = "KZ" + value;
                else
                    _number = value;
            }
        }
        public DateTime ExpiryDate{ get; set; }
        public int TypeAccount { get; set; }

    }
}
