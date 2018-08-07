﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models.EntityModels;

namespace RMS.BLL.Contracts
{
    public interface IDesignationManager:IManager<Designation>
    {
        ICollection<Designation> SearchByTitle(string searchDesignationTitle);
    }
}
