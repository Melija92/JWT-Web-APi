﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JWT_Web_Api.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public int BookId { get; set; }
    }
}