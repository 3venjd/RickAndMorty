using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RickAndMorty.Shared.Data
{

    public class Episodes
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Air_date { get; set; }
        public string? Episode { get; set; }
        public List<string>? Characters { get; set; }
        public string? Url { get; set; }
        public DateTime Created { get; set; }
    }

}
