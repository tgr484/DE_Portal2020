using System;
using System.Collections.Generic;
using System.Text;

namespace DE_Portal.DAL.Models
{
    public class ProjectModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ClientName { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string Description { get; set; }
        public string Tl { get; set; }
        public string Am { get; set; }
        public string Os { get; set; }    
        
        public bool IsActive { get; set; }
    }
}
