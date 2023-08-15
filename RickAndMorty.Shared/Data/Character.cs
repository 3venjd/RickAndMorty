﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{

    public class Characters
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Status { get; set; }
        public string? Species { get; set; }
        public string? Type { get; set; }
        public string? Gender { get; set; }
        public Origin? OriginName { get; set; }
        public Location? LocationName { get; set; }
        public string? Image { get; set; }
        public ICollection<Episode>? Episode { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }

}
