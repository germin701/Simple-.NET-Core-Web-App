using EF.Core.Repository.Interface.Repository;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Interfaces.Repository
{
    interface IStaffRepository:ICommonRepository<Staff>
    {
    }
}
