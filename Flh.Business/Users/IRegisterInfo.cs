﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flh.Business.Users
{
    public interface IRegisterInfo
    {
        string Mobile { get; }
        string Email { get; }
        string Password { get; }
        string Name { get; }
        string Company { get; }
        string AreaNo { get; }
        string Address { get; }
        EmployeesCountRanges EmployeesCountRange { get; }
        string IndustryNo { get; }
        bool IsPurchaser { get; }
        bool NeetInvoice { get; }
        string Tel { get; }
        string Code { get; set; }
    }
}
