﻿using System;
using System.Collections.Generic;

namespace DesignPatters.Models
{
    public partial class Beer
    {
        public int BeerId { get; set; }
        public string? Name { get; set; }
        public string? Style { get; set; }
        public Guid? Branid { get; set; }
    }
}
