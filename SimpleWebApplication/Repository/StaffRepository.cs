using EF.Core.Repository.Repository;
using Microsoft.EntityFrameworkCore;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Repository
{
    public class StaffRepository : CommonRepository<Staff>, Interfaces.Repository.IStaffRepository
    {
        public StaffRepository(DbContext dbContext) : base(dbContext)
        {
        }
    }
}
