using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Emlakcim.Entity
{
    public class Employment
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Title { get; set; }

        public bool Status { get; set; }

        public int WhoWeAreId { get; set; }
        public WhoWeAre WhoWeAre { get; set; }
    }
}
