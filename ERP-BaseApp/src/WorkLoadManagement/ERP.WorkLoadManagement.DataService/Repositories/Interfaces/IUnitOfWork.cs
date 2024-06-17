﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.WorkLoadManagement.DataService.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IWorkRepository Works {  get; }
        Task<bool> CompleteAsync();
    }
}
