﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace consultants.Models
{
    public class Details
    {
        public int Assignment_ID { get; set; }
        public string Assignment_Name { get; set; }

        public string Client_Name { get; set; }
        public string Percentage { get; set; }
        public DateTime Start_Date { get; set; }
        public DateTime End_Date { get; set; }
        public string Comment { get; set; }
        public string Consultant_Name { get; set; }
        public bool Is_Deadline { get; set; }

}
}