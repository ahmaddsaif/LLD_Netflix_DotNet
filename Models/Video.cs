using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class Video : BaseModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Actor> Actors { get; set; }
        public ICollection<WatchHistory> WatchHistories { get; set; }
    }
}
