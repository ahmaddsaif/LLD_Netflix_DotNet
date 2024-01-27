using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetflixSchemaDesignMVC_DotNet.Models
{
    public class Cast : BaseModel
    {
        public long ActorId { get; set; }
        public long VideoId { get; set; }
    }
}
