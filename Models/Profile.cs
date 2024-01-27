using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class Profile : BaseModel
    {
        public string Name { get; set; }
        public User User { get; set; }
        public ProfileType ProfileType { get; set; }
        public ICollection<WatchHistory> WatchHistories { get; set; }
    }
}
