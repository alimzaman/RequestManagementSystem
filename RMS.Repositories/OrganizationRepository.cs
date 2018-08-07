﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models.DatabaseContext;
using RMS.Models.EntityModels;
using RMS.Repositories.Base;
using RMS.Repositories.Contracts;

namespace RMS.Repositories
{
    public class OrganizationRepository:Repository<Organization>,IOrganizationRepository
    {

        public OrganizationRepository(DbContext db) : base(db)
        {
        }

        public ICollection<Organization> SearchByName(string searchTextOrgName)
        {
            return db.Set<Organization>().Where(c => c.Name.StartsWith(searchTextOrgName)).ToList();
        }
    }
}
