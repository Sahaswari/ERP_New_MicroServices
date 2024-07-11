using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.TrainingManagement.Core.DTOs.Requests
{
    public class CreateInternshipVacancyRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Company { get; set; }
        public string Company_Person { get; set; }

        public string address { get; set; }
        // public Guid CoordinatorId { get; set; }
    }
}
