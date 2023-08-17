using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{

    public class ApiCharacters
    {
        public int id { get; set; }
        public string? name { get; set; }
        public string? status { get; set; }
        public string? species { get; set; }
        public string? type { get; set; }
        public string? gender { get; set; }
        public ApiOrigin? origin { get; set; }
        public ApiLocation? location { get; set; }
        public string? image { get; set; }
        public ICollection<string>? episode { get; set; }
        public string? url { get; set; }
        public DateTime created { get; set; }
    }

}
