using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class Actor : BaseModel
    {
        public string Name { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
