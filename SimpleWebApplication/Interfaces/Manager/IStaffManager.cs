using EF.Core.Repository.Interface.Manager;
using SimpleWebApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleWebApplication.Interfaces.Manager
{
    interface IStaffManager:ICommonManager<Staff>
    {
        Staff GetById(int id);
    }
}
