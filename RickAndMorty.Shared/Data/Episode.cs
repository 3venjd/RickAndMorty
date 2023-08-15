using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{

    public class Episode
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Air_date { get; set; }
        public string? Episodes { get; set; }
        public List<string>? ListCharacters { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }

}
