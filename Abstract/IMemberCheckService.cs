using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Abstract
{
    interface IMemberCheckService
    {
        bool CheckIfRealMember(Member member);
    }
}
