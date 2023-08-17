using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{
    public class GeneralResponse<T>
    {
        public Info? info { get; set; }

        public List<T>? results { get; set; }

    }

    public class Info
    {
        public int count { get; set; }
        public int pages { get; set; }
        public string? next { get; set; }

        public string? prev { get; set; }
    }
}
