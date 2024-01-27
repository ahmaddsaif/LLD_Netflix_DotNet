using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class WatchHistory : BaseModel
    {
        public Profile Profile { get; set; }
        public Video Video { get; set; }
        public WatchStatus WatchStatus { get; set; }
        public DateTime? LastWatched { get; set; }
    }
}
