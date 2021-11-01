using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Abstract;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Concrete
{
    class MemberCheckManager:IMemberCheckService
    {
        public bool CheckIfRealMember(Member member)
        {
            return true;
        }
    }
}
