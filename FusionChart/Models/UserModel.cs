﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FusionChart.Models
{
    public class UserModel
    {
         public int UserId { get; set; }
         public string UserName { get; set; }
         public string Company { get; set; }
         public string label { get; set; }
         public string value { get; set; }
    }
}