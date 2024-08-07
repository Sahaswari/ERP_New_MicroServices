﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.TrainingManagement.Core.Entities
{
    public class ApprovalRequest : BaseEntity
    {
        public Guid Id { get; set; }
        public Guid StudentId { get; set; }
        public string Company { get; set; }
        
        public Guid? ApprovedById { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual Student Student { get; set; }
        public virtual Coordinator ApprovedBy { get; set; }
    }
}
