﻿using System;
using System.Collections.Generic;

#nullable disable

namespace StackOverflowDemo.Api.Data
{
    public partial class Badge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime Date { get; set; }
    }
}
