using System;
using System.Collections.Generic;
using System.Text;
using GameSalesDemo.Entities;

namespace GameSalesDemo.Abstract
{
    interface IMemberService
    {
        void Add(Member member);
        void Update(Member member);
        void Delete(Member member);

    }
}
