using AutoMapper;
using LM.Data;
using LM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LM.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<LeaveType, LeaveTypeVM>().ReverseMap();
            

            CreateMap<LeaveRequest, LeaveRequestVM>().ReverseMap();

            CreateMap<LeaveAllocation, LeaveAllocationVM>().ReverseMap();

            CreateMap<LeaveAllocation, EditLeaveAllocationVM>().ReverseMap();

            CreateMap<Employee, EmployeeVM>().ReverseMap();



        }
    }
}
