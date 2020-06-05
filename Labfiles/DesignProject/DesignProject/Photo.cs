using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignProject
{
    class Photo
    {
        public int PhotoId { get; set; }
        public string Title { get; set; }
        public byte PhotoFile { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Owner { get; set; }
    }
}
