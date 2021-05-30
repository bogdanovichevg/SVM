using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SWM_APP.Models.DdContext.Entity
{
    [Table("wsref")]
    public class WSREF
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public string Description { get; set; }
        public int Minus { get; set; }
        public int Plus { get; set; }
    }
}
