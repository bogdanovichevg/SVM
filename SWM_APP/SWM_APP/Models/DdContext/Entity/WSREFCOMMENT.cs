using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWM_APP.Models.DdContext.Entity
{
    [Table("wsrefcomment")]
    public class WSREFCOMMENT
    {
        public int Id { get; set; }
        public int Wsref_id { get; set; }
        public int Session_id { get; set; }
        public DateTime Stamp { get; set; }
        public String Comtext { get; set; }
    }
}
