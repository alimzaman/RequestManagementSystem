﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RMS.Models.EntityModels;
using RMS.Repositories.Base;
using RMS.Repositories.Contracts;

namespace RMS.Repositories
{
    public class RequisitionStatusRepository:Repository<RequisitionStatus>,IRequisitionStatusRepository
    {
        public RequisitionStatusRepository(DbContext db) : base(db)
        {
        }

        public ICollection<RequisitionStatus> GetAllWithRequisitionDetails()
        {
            return db.Set<RequisitionStatus>().Include(c => c.Requisition).Where(c=>c.StatusType=="Assigned").ToList();
        }

        public ICollection<RequisitionStatus> GetAllStatusNew()
        {
            return db.Set<RequisitionStatus>().Include(c => c.Requisition).Where(c => c.StatusType == "New").ToList();
        }
        public ICollection<RequisitionStatus> GetAllStatusExecute()
        {
            return db.Set<RequisitionStatus>().Include(c => c.Requisition).Where(c => c.StatusType == "OnExecute").ToList();
        }

    }
}