﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetromApp.Models
{
    public class LikeModel
    {
        public int Id { get; set; }
        public int Id_Postare { get; set; }
        public string Id_User { get; set; }
        public DateTime? LastUpdated { get; set; }
    }
}