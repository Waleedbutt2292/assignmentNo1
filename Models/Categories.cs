using System;
using System.Collections.Generic;

namespace NewTask.Models
{
    public partial class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string ModifiedBy { get; set; }
        public string Image { get; set; }
    }
}
