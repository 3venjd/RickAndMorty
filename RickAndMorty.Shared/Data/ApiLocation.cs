﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{

    public class ApiLocation
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Dimension { get; set; }
        public ICollection<Characters>? Residents { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }

}