using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G02_API02.entities
{
    public class BaseEntity<TKey>
    {
        public int TKeyId { get; set; }
        public DateTime CreateAt { get; set; } = DateTime.UtcNow;
    }
}
