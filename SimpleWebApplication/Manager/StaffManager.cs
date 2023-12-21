using SimpleWebApplication.Data;
using SimpleWebApplication.Interfaces.Manager;
using SimpleWebApplication.Models;
using SimpleWebApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Manager
{
    public class StaffManager: EF.Core.Repository.Manager.CommonManager<Staff>, IStaffManager
    {
        public StaffManager(ApplicationDBContext dBContext):base(new StaffRepository(dBContext))
        {

        }

        public Staff GetById(int id)
        {
            return GetFirstOrDefault(c => c.Id == id);
        }
    }
}
